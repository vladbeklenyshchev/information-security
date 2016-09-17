namespace InfoProtection
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.progressCoding = new System.Windows.Forms.ProgressBar();
            this.textBoxForInput = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_SelectKeys = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_DownloadFile = new System.Windows.Forms.Button();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.label_P = new System.Windows.Forms.Label();
            this.label_Q = new System.Windows.Forms.Label();
            this.labelPrivateKey = new System.Windows.Forms.Label();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.button_LoadPublicKey = new System.Windows.Forms.Button();
            this.button_LoadPrivateKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(13, 210);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(237, 31);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Location = new System.Drawing.Point(255, 210);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(237, 31);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // progressCoding
            // 
            this.progressCoding.Location = new System.Drawing.Point(12, 116);
            this.progressCoding.Name = "progressCoding";
            this.progressCoding.Size = new System.Drawing.Size(722, 14);
            this.progressCoding.TabIndex = 6;
            // 
            // textBoxForInput
            // 
            this.textBoxForInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForInput.Location = new System.Drawing.Point(12, 25);
            this.textBoxForInput.Multiline = true;
            this.textBoxForInput.Name = "textBoxForInput";
            this.textBoxForInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForInput.Size = new System.Drawing.Size(237, 85);
            this.textBoxForInput.TabIndex = 0;
            this.textBoxForInput.Text = "Hello, World!";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(498, 210);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(236, 31);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить окна";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCipher.Location = new System.Drawing.Point(255, 25);
            this.textBoxCipher.Multiline = true;
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.ReadOnly = true;
            this.textBoxCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCipher.Size = new System.Drawing.Size(237, 85);
            this.textBoxCipher.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(498, 25);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(236, 85);
            this.textBoxResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Область для ввода данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Зашифрованные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Результат дешифровки";
            // 
            // button_SelectKeys
            // 
            this.button_SelectKeys.Location = new System.Drawing.Point(13, 136);
            this.button_SelectKeys.Name = "button_SelectKeys";
            this.button_SelectKeys.Size = new System.Drawing.Size(236, 31);
            this.button_SelectKeys.TabIndex = 18;
            this.button_SelectKeys.Text = "Подобрать ключи";
            this.button_SelectKeys.UseVisualStyleBackColor = true;
            this.button_SelectKeys.Click += new System.EventHandler(this.button_SelectKeys_Click);
            // 
            // button_DownloadFile
            // 
            this.button_DownloadFile.Location = new System.Drawing.Point(13, 173);
            this.button_DownloadFile.Name = "button_DownloadFile";
            this.button_DownloadFile.Size = new System.Drawing.Size(236, 31);
            this.button_DownloadFile.TabIndex = 25;
            this.button_DownloadFile.Text = "Загрузить файл для шифрования";
            this.button_DownloadFile.UseVisualStyleBackColor = true;
            this.button_DownloadFile.Click += new System.EventHandler(this.button_DownloadFile_Click);
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(89, 17);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(77, 20);
            this.textBoxPublicKey.TabIndex = 14;
            this.textBoxPublicKey.Leave += new System.EventHandler(this.textBoxKey_Leave);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(21, 20);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(62, 13);
            this.labelKey.TabIndex = 15;
            this.labelKey.Text = "Открытый:";
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(68, 16);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(123, 20);
            this.textBox_P.TabIndex = 16;
            this.textBox_P.Text = "3";
            // 
            // textBox_Q
            // 
            this.textBox_Q.Location = new System.Drawing.Point(68, 42);
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(123, 20);
            this.textBox_Q.TabIndex = 17;
            this.textBox_Q.Text = "11";
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(40, 19);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(22, 13);
            this.label_P.TabIndex = 19;
            this.label_P.Text = "p =";
            // 
            // label_Q
            // 
            this.label_Q.AutoSize = true;
            this.label_Q.Location = new System.Drawing.Point(40, 45);
            this.label_Q.Name = "label_Q";
            this.label_Q.Size = new System.Drawing.Size(22, 13);
            this.label_Q.TabIndex = 20;
            this.label_Q.Text = "q =";
            // 
            // labelPrivateKey
            // 
            this.labelPrivateKey.AutoSize = true;
            this.labelPrivateKey.Location = new System.Drawing.Point(21, 46);
            this.labelPrivateKey.Name = "labelPrivateKey";
            this.labelPrivateKey.Size = new System.Drawing.Size(62, 13);
            this.labelPrivateKey.TabIndex = 21;
            this.labelPrivateKey.Text = "Закрытый:";
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(89, 42);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(77, 20);
            this.textBoxPrivateKey.TabIndex = 22;
            // 
            // button_LoadPublicKey
            // 
            this.button_LoadPublicKey.Location = new System.Drawing.Point(172, 16);
            this.button_LoadPublicKey.Name = "button_LoadPublicKey";
            this.button_LoadPublicKey.Size = new System.Drawing.Size(26, 20);
            this.button_LoadPublicKey.TabIndex = 23;
            this.button_LoadPublicKey.Text = "..";
            this.button_LoadPublicKey.UseVisualStyleBackColor = true;
            this.button_LoadPublicKey.Click += new System.EventHandler(this.button_LoadPublicKey_Click);
            // 
            // button_LoadPrivateKey
            // 
            this.button_LoadPrivateKey.Location = new System.Drawing.Point(172, 42);
            this.button_LoadPrivateKey.Name = "button_LoadPrivateKey";
            this.button_LoadPrivateKey.Size = new System.Drawing.Size(26, 20);
            this.button_LoadPrivateKey.TabIndex = 24;
            this.button_LoadPrivateKey.Text = "..";
            this.button_LoadPrivateKey.UseVisualStyleBackColor = true;
            this.button_LoadPrivateKey.Click += new System.EventHandler(this.button_LoadPrivateKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Q);
            this.groupBox1.Controls.Add(this.label_P);
            this.groupBox1.Controls.Add(this.textBox_Q);
            this.groupBox1.Controls.Add(this.textBox_P);
            this.groupBox1.Location = new System.Drawing.Point(267, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 69);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Простые числа";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_LoadPrivateKey);
            this.groupBox2.Controls.Add(this.button_LoadPublicKey);
            this.groupBox2.Controls.Add(this.textBoxPrivateKey);
            this.groupBox2.Controls.Add(this.labelPrivateKey);
            this.groupBox2.Controls.Add(this.labelKey);
            this.groupBox2.Controls.Add(this.textBoxPublicKey);
            this.groupBox2.Location = new System.Drawing.Point(512, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 68);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключи";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(746, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_DownloadFile);
            this.Controls.Add(this.button_SelectKeys);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxCipher);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxForInput);
            this.Controls.Add(this.progressCoding);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Методы защиты информации. Лаб 4. Бекленищев Влад";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.ProgressBar progressCoding;
        private System.Windows.Forms.TextBox textBoxForInput;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_SelectKeys;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_DownloadFile;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Q;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Label label_Q;
        private System.Windows.Forms.Label labelPrivateKey;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Button button_LoadPublicKey;
        private System.Windows.Forms.Button button_LoadPrivateKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

