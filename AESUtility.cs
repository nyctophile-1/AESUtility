using Core.Services;
using System.Text;

namespace AESUtility
{
    public partial class AESUtility : Form
    {
        public AESUtility()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _masterKey = masterKey.Text.Trim();
            string _plainText = plainText.Text.Trim();

            // Numeric values
            int? _iterations = (int?)iterations.Value;
            int? _saltSize = (int?)saltSize.Value;
            int? _tagSize = (int?)tagSize.Value;
            int? _ivSize = (int?)IVsize.Value;
            int? _keySize = (int?)keySize.Value;

            // Mode (Encrypt / Decrypt)
            string _mode = algo.SelectedItem?.ToString() ?? string.Empty;

            // Optional validation
            if (string.IsNullOrWhiteSpace(_masterKey))
            {
                MessageBox.Show("Please enter Master Key.");
                return;
            }

            if (string.IsNullOrWhiteSpace(_mode))
            {
                MessageBox.Show("Please select Encrypt / Decrypt.");
                return;
            }

            var keyUtility = new KeyDecryptionUtility(_masterKey, _iterations, _keySize, _ivSize, _tagSize, _saltSize);
            if (_mode == "Encryption")
            {
                var str = Encoding.UTF8.GetBytes(_plainText);
                result.Text = keyUtility.EncryptKeyToBase64((str));
            }
            else
            {
                result.Text = Encoding.UTF8.GetString(keyUtility.DecryptKeyFromBase64((_plainText)));
            }

        }
    }
}
