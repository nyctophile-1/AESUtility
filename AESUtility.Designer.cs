namespace AESUtility
{
    partial class AESUtility
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            plainText = new TextBox();
            labl8 = new Label();
            keySize = new NumericUpDown();
            IVsize = new NumericUpDown();
            tagSize = new NumericUpDown();
            saltSize = new NumericUpDown();
            labl1 = new Label();
            labl2 = new Label();
            labl3 = new Label();
            labl4 = new Label();
            labl5 = new Label();
            labl6 = new Label();
            labl7 = new Label();
            masterKey = new TextBox();
            iterations = new NumericUpDown();
            algo = new ComboBox();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            result = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)keySize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IVsize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tagSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saltSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iterations).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(plainText, 1, 7);
            tableLayoutPanel1.Controls.Add(labl8, 0, 7);
            tableLayoutPanel1.Controls.Add(keySize, 1, 5);
            tableLayoutPanel1.Controls.Add(IVsize, 1, 4);
            tableLayoutPanel1.Controls.Add(tagSize, 1, 3);
            tableLayoutPanel1.Controls.Add(saltSize, 1, 2);
            tableLayoutPanel1.Controls.Add(labl1, 0, 0);
            tableLayoutPanel1.Controls.Add(labl2, 0, 1);
            tableLayoutPanel1.Controls.Add(labl3, 0, 2);
            tableLayoutPanel1.Controls.Add(labl4, 0, 3);
            tableLayoutPanel1.Controls.Add(labl5, 0, 4);
            tableLayoutPanel1.Controls.Add(labl6, 0, 5);
            tableLayoutPanel1.Controls.Add(labl7, 0, 6);
            tableLayoutPanel1.Controls.Add(masterKey, 1, 0);
            tableLayoutPanel1.Controls.Add(iterations, 1, 1);
            tableLayoutPanel1.Controls.Add(algo, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(776, 295);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // plainText
            // 
            plainText.Dock = DockStyle.Fill;
            plainText.Location = new Point(274, 265);
            plainText.Name = "plainText";
            plainText.Size = new Size(499, 27);
            plainText.TabIndex = 15;
            // 
            // labl8
            // 
            labl8.AutoSize = true;
            labl8.Dock = DockStyle.Fill;
            labl8.Location = new Point(3, 262);
            labl8.Name = "labl8";
            labl8.Size = new Size(265, 33);
            labl8.TabIndex = 1;
            labl8.Text = "Plain Text";
            labl8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // keySize
            // 
            keySize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            keySize.Location = new Point(274, 195);
            keySize.Margin = new Padding(3, 6, 3, 6);
            keySize.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            keySize.Name = "keySize";
            keySize.Size = new Size(499, 27);
            keySize.TabIndex = 13;
            keySize.TextAlign = HorizontalAlignment.Right;
            keySize.ThousandsSeparator = true;
            keySize.Value = new decimal(new int[] { 256, 0, 0, 0 });
            // 
            // IVsize
            // 
            IVsize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IVsize.Location = new Point(274, 156);
            IVsize.Margin = new Padding(3, 6, 3, 6);
            IVsize.Name = "IVsize";
            IVsize.Size = new Size(499, 27);
            IVsize.TabIndex = 12;
            IVsize.TextAlign = HorizontalAlignment.Right;
            IVsize.ThousandsSeparator = true;
            IVsize.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // tagSize
            // 
            tagSize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tagSize.Location = new Point(274, 117);
            tagSize.Margin = new Padding(3, 6, 3, 6);
            tagSize.Name = "tagSize";
            tagSize.Size = new Size(499, 27);
            tagSize.TabIndex = 11;
            tagSize.TextAlign = HorizontalAlignment.Right;
            tagSize.ThousandsSeparator = true;
            tagSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // saltSize
            // 
            saltSize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saltSize.Location = new Point(274, 78);
            saltSize.Margin = new Padding(3, 6, 3, 6);
            saltSize.Name = "saltSize";
            saltSize.Size = new Size(499, 27);
            saltSize.TabIndex = 10;
            saltSize.TextAlign = HorizontalAlignment.Right;
            saltSize.ThousandsSeparator = true;
            saltSize.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // labl1
            // 
            labl1.AutoSize = true;
            labl1.Dock = DockStyle.Fill;
            labl1.Location = new Point(3, 0);
            labl1.Name = "labl1";
            labl1.Size = new Size(265, 33);
            labl1.TabIndex = 1;
            labl1.Text = "Master Key";
            labl1.TextAlign = ContentAlignment.MiddleCenter;
            labl1.Click += label2_Click;
            // 
            // labl2
            // 
            labl2.AutoSize = true;
            labl2.Dock = DockStyle.Fill;
            labl2.Location = new Point(3, 33);
            labl2.Name = "labl2";
            labl2.Size = new Size(265, 39);
            labl2.TabIndex = 2;
            labl2.Text = "Iterations";
            labl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labl3
            // 
            labl3.AutoSize = true;
            labl3.Dock = DockStyle.Fill;
            labl3.Location = new Point(3, 72);
            labl3.Name = "labl3";
            labl3.Size = new Size(265, 39);
            labl3.TabIndex = 3;
            labl3.Text = "Salt Size";
            labl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labl4
            // 
            labl4.AutoSize = true;
            labl4.Dock = DockStyle.Fill;
            labl4.Location = new Point(3, 111);
            labl4.Name = "labl4";
            labl4.Size = new Size(265, 39);
            labl4.TabIndex = 4;
            labl4.Text = "Tag Size";
            labl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labl5
            // 
            labl5.AutoSize = true;
            labl5.Dock = DockStyle.Fill;
            labl5.Location = new Point(3, 150);
            labl5.Name = "labl5";
            labl5.Size = new Size(265, 39);
            labl5.TabIndex = 5;
            labl5.Text = "IV Size";
            labl5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labl6
            // 
            labl6.AutoSize = true;
            labl6.Dock = DockStyle.Fill;
            labl6.Location = new Point(3, 189);
            labl6.Name = "labl6";
            labl6.Size = new Size(265, 39);
            labl6.TabIndex = 6;
            labl6.Text = "Key Size";
            labl6.TextAlign = ContentAlignment.MiddleCenter;
            labl6.Click += label1_Click_2;
            // 
            // labl7
            // 
            labl7.AutoSize = true;
            labl7.Dock = DockStyle.Fill;
            labl7.Location = new Point(3, 228);
            labl7.Name = "labl7";
            labl7.Size = new Size(265, 34);
            labl7.TabIndex = 7;
            labl7.Text = "Encryption/Decryption";
            labl7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // masterKey
            // 
            masterKey.Dock = DockStyle.Fill;
            masterKey.Location = new Point(274, 3);
            masterKey.Name = "masterKey";
            masterKey.Size = new Size(499, 27);
            masterKey.TabIndex = 8;
            // 
            // iterations
            // 
            iterations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iterations.AutoSize = true;
            iterations.Location = new Point(274, 39);
            iterations.Margin = new Padding(3, 6, 3, 6);
            iterations.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            iterations.Name = "iterations";
            iterations.Size = new Size(499, 27);
            iterations.TabIndex = 9;
            iterations.TextAlign = HorizontalAlignment.Right;
            iterations.ThousandsSeparator = true;
            iterations.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // algo
            // 
            algo.Dock = DockStyle.Fill;
            algo.DropDownStyle = ComboBoxStyle.DropDownList;
            algo.FormattingEnabled = true;
            algo.Items.AddRange(new object[] { "Encryption", "Decryption" });
            algo.Location = new Point(274, 231);
            algo.Name = "algo";
            algo.Size = new Size(499, 28);
            algo.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(349, 341);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(result, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(12, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(776, 33);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 6);
            label1.Margin = new Padding(3, 6, 3, 6);
            label1.Name = "label1";
            label1.Size = new Size(265, 21);
            label1.TabIndex = 0;
            label1.Text = "Result";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            result.Dock = DockStyle.Fill;
            result.Location = new Point(274, 3);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(499, 27);
            result.TabIndex = 1;
            // 
            // AESUtility
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 440);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Name = "AESUtility";
            Padding = new Padding(12);
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)keySize).EndInit();
            ((System.ComponentModel.ISupportInitialize)IVsize).EndInit();
            ((System.ComponentModel.ISupportInitialize)tagSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)saltSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iterations).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labl1;
        private Label labl2;
        private Label labl3;
        private Label labl4;
        private Label labl5;
        private Label labl6;
        private Label labl7;
        private TextBox masterKey;
        private NumericUpDown keySize;
        private NumericUpDown IVsize;
        private NumericUpDown tagSize;
        private NumericUpDown saltSize;
        private NumericUpDown iterations;
        private ComboBox algo;
        private Label labl8;
        private TextBox plainText;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox result;
    }
}
