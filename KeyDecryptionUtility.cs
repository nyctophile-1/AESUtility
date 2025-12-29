using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Core.Services;

public class KeyDecryptionUtility
{
    private byte[] _masterKey;
    private readonly int _pbkdf2Iterations;
    private readonly int _keySize;
    private readonly int _ivSize;
    private readonly int _tagSize;
    private readonly int _saltSize;

    private ConcurrentDictionary<string, byte[]> _decodedCache
          = new(StringComparer.Ordinal);
    private readonly SecureRandom _random = new SecureRandom();
    public KeyDecryptionUtility(
        string masterKey,
        int? iterations,
        int? keySize,
        int? ivSize,
        int? tagSize,
        int? saltSize)
    {
        _masterKey = ParseMasterKey(masterKey);
        _pbkdf2Iterations = iterations ?? 1000;
        _keySize = keySize ?? 256;
        _ivSize = ivSize ?? 12;
        _tagSize = tagSize ?? 16;
        _saltSize = saltSize ?? 32;
    }

    private byte[] EncryptKey(byte[] plain)
    {
        if (plain == null || plain.Length == 0)
            return Array.Empty<byte>();

        // generate salt
        var salt = new byte[_saltSize];
        _random.NextBytes(salt);

        // derive key
        var derivedKey = DeriveKey(_masterKey, salt, _keySize / 8);

        // generate random iv
        var iv = new byte[_ivSize];
        _random.NextBytes(iv);

        // encrypt
        var (cipher, tag) = EncryptAesGcm(derivedKey, iv, plain);

        // combine [salt][iv][cipher][tag]
        var final = new byte[salt.Length + iv.Length + cipher.Length + tag.Length];

        Buffer.BlockCopy(salt, 0, final, 0, salt.Length);
        Buffer.BlockCopy(iv, 0, final, salt.Length, iv.Length);
        Buffer.BlockCopy(cipher, 0, final, salt.Length + iv.Length, cipher.Length);
        Buffer.BlockCopy(tag, 0, final, salt.Length + iv.Length + cipher.Length, tag.Length);

        return final;
    }
    private byte[] DecryptKey(byte[] encryptedKey)
    {
        if (encryptedKey == null || encryptedKey.Length == 0)
            return Array.Empty<byte>();

        var salt = new byte[_saltSize];
        var iv = new byte[_ivSize];
        var tag = new byte[_tagSize];
        var cipherText = new byte[encryptedKey.Length - _saltSize - _ivSize - _tagSize];

        Buffer.BlockCopy(encryptedKey, 0, salt, 0, _saltSize);
        Buffer.BlockCopy(encryptedKey, _saltSize, iv, 0, _ivSize);
        Buffer.BlockCopy(encryptedKey, _saltSize + _ivSize, cipherText, 0, cipherText.Length);
        Buffer.BlockCopy(encryptedKey, _saltSize + _ivSize + cipherText.Length, tag, 0, _tagSize);

        var derivedKey = DeriveKey(_masterKey, salt, _keySize / 8);

        return DecryptAesGcm(derivedKey, iv, cipherText, tag);
    }
    public string EncryptKeyToBase64(byte[] plain)
              => Convert.ToBase64String(EncryptKey(plain));
    public byte[] DecryptKeyFromBase64(string encryptedKeyBase64)
    {
        if (string.IsNullOrWhiteSpace(encryptedKeyBase64))
            return Array.Empty<byte>();

        if (_decodedCache.TryGetValue(encryptedKeyBase64, out var result))
        {
            return result;
        }
        else
        {
            var decryptedKey = DecryptKey(Convert.FromBase64String(encryptedKeyBase64));
            _decodedCache.TryAdd(encryptedKeyBase64, decryptedKey);
            return decryptedKey;
        }
    }
    private byte[] ParseMasterKey(string masterKey)
    {
        try { return Convert.FromBase64String(masterKey); } catch { }
        return Encoding.UTF8.GetBytes(masterKey);
    }
    private byte[] DeriveKey(byte[] masterKey, byte[] salt, int keyLength)
    {
        var generator = new Pkcs5S2ParametersGenerator(new Sha256Digest());
        generator.Init(masterKey, salt, _pbkdf2Iterations);
        return ((KeyParameter)generator.GenerateDerivedParameters("AES", keyLength * 8)).GetKey();
    }

    private (byte[] cipher, byte[] tag) EncryptAesGcm(byte[] key, byte[] iv, byte[] plain)
    {
        var cipher = new GcmBlockCipher(new AesEngine());
        var parameters = new AeadParameters(new KeyParameter(key), _tagSize * 8, iv);

        cipher.Init(true, parameters);

        // BC returns [cipher||tag] in one block. We'll split.
        var output = new byte[cipher.GetOutputSize(plain.Length)];
        var len = cipher.ProcessBytes(plain, 0, plain.Length, output, 0);
        cipher.DoFinal(output, len);

        var ciphertext = new byte[output.Length - _tagSize];
        var tag = new byte[_tagSize];

        Buffer.BlockCopy(output, 0, ciphertext, 0, ciphertext.Length);
        Buffer.BlockCopy(output, ciphertext.Length, tag, 0, tag.Length);

        return (ciphertext, tag);
    }
    private byte[] DecryptAesGcm(byte[] key, byte[] iv, byte[] cipherText, byte[] tag)
    {
        var cipher = new GcmBlockCipher(new AesEngine());
        var parameters = new AeadParameters(new KeyParameter(key), _tagSize * 8, iv);

        cipher.Init(false, parameters);

        var input = cipherText.Concat(tag).ToArray();
        var output = new byte[cipher.GetOutputSize(input.Length)];

        var len = cipher.ProcessBytes(input, 0, input.Length, output, 0);
        cipher.DoFinal(output, len);

        return output;
    }
}