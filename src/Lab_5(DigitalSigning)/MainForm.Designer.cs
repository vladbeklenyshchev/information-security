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
            this.textBox_SendMessage = new System.Windows.Forms.TextBox();
            this.button_SelectKeys = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.label_P = new System.Windows.Forms.Label();
            this.label_Q = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Verify = new System.Windows.Forms.Button();
            this.button_GetDigestFromSendedMessage = new System.Windows.Forms.Button();
            this.textBox_MessageDigest = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_ReceiveMessage = new System.Windows.Forms.TextBox();
            this.textBox_MessageDigestAfterDigestAlg = new System.Windows.Forms.TextBox();
            this.textBox_SendEncryptedMessageDigest = new System.Windows.Forms.TextBox();
            this.button_GetDigestFromReceivedMessage = new System.Windows.Forms.Button();
            this.textBox_ReceiveEncryptedMessageDigest = new System.Windows.Forms.TextBox();
            this.textBox_MessageDigestAfterDecryptionByPublicKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Sign = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифроватьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Location = new System.Drawing.Point(253, 197);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(163, 67);
            this.buttonEncrypt.TabIndex = 8;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Location = new System.Drawing.Point(250, 197);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(163, 67);
            this.buttonDecrypt.TabIndex = 15;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // progressCoding
            // 
            this.progressCoding.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressCoding.Location = new System.Drawing.Point(12, 41);
            this.progressCoding.Name = "progressCoding";
            this.progressCoding.Size = new System.Drawing.Size(844, 21);
            this.progressCoding.TabIndex = 6;
            // 
            // textBox_SendMessage
            // 
            this.textBox_SendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SendMessage.Location = new System.Drawing.Point(7, 15);
            this.textBox_SendMessage.Multiline = true;
            this.textBox_SendMessage.Name = "textBox_SendMessage";
            this.textBox_SendMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SendMessage.Size = new System.Drawing.Size(238, 67);
            this.textBox_SendMessage.TabIndex = 0;
            this.textBox_SendMessage.Text = "The quick brown fox jumps over the lazy dog";
            // 
            // button_SelectKeys
            // 
            this.button_SelectKeys.Location = new System.Drawing.Point(252, 88);
            this.button_SelectKeys.Name = "button_SelectKeys";
            this.button_SelectKeys.Size = new System.Drawing.Size(164, 30);
            this.button_SelectKeys.TabIndex = 4;
            this.button_SelectKeys.Text = "Подобрать ключи";
            this.button_SelectKeys.UseVisualStyleBackColor = true;
            this.button_SelectKeys.Click += new System.EventHandler(this.button_SelectKeys_Click);
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(43, 16);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(95, 20);
            this.textBox_P.TabIndex = 1;
            this.textBox_P.Text = "3";
            // 
            // textBox_Q
            // 
            this.textBox_Q.Location = new System.Drawing.Point(43, 42);
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(95, 20);
            this.textBox_Q.TabIndex = 2;
            this.textBox_Q.Text = "11";
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(15, 19);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(22, 13);
            this.label_P.TabIndex = 19;
            this.label_P.Text = "p =";
            // 
            // label_Q
            // 
            this.label_Q.AutoSize = true;
            this.label_Q.Location = new System.Drawing.Point(15, 45);
            this.label_Q.Name = "label_Q";
            this.label_Q.Size = new System.Drawing.Size(22, 13);
            this.label_Q.TabIndex = 20;
            this.label_Q.Text = "q =";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Q);
            this.groupBox1.Controls.Add(this.label_P);
            this.groupBox1.Controls.Add(this.textBox_Q);
            this.groupBox1.Controls.Add(this.textBox_P);
            this.groupBox1.Location = new System.Drawing.Point(252, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Простые числа";
            // 
            // button_Verify
            // 
            this.button_Verify.Enabled = false;
            this.button_Verify.Location = new System.Drawing.Point(6, 269);
            this.button_Verify.Name = "button_Verify";
            this.button_Verify.Size = new System.Drawing.Size(407, 30);
            this.button_Verify.TabIndex = 16;
            this.button_Verify.Text = "Проверить";
            this.button_Verify.UseVisualStyleBackColor = true;
            this.button_Verify.Click += new System.EventHandler(this.button_Verify_Click);
            // 
            // button_GetDigestFromSendedMessage
            // 
            this.button_GetDigestFromSendedMessage.Enabled = false;
            this.button_GetDigestFromSendedMessage.Location = new System.Drawing.Point(253, 124);
            this.button_GetDigestFromSendedMessage.Name = "button_GetDigestFromSendedMessage";
            this.button_GetDigestFromSendedMessage.Size = new System.Drawing.Size(163, 67);
            this.button_GetDigestFromSendedMessage.TabIndex = 6;
            this.button_GetDigestFromSendedMessage.Text = "Получить дайджест";
            this.button_GetDigestFromSendedMessage.UseVisualStyleBackColor = true;
            this.button_GetDigestFromSendedMessage.Click += new System.EventHandler(this.button_GetDigestFromSendedMessage_Click);
            // 
            // textBox_MessageDigest
            // 
            this.textBox_MessageDigest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MessageDigest.Location = new System.Drawing.Point(9, 124);
            this.textBox_MessageDigest.Multiline = true;
            this.textBox_MessageDigest.Name = "textBox_MessageDigest";
            this.textBox_MessageDigest.ReadOnly = true;
            this.textBox_MessageDigest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_MessageDigest.Size = new System.Drawing.Size(238, 67);
            this.textBox_MessageDigest.TabIndex = 5;
            // 
            // button_Send
            // 
            this.button_Send.Enabled = false;
            this.button_Send.Location = new System.Drawing.Point(9, 269);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(406, 30);
            this.button_Send.TabIndex = 9;
            this.button_Send.Text = "Отправить";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_ReceiveMessage
            // 
            this.textBox_ReceiveMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ReceiveMessage.Location = new System.Drawing.Point(6, 15);
            this.textBox_ReceiveMessage.Multiline = true;
            this.textBox_ReceiveMessage.Name = "textBox_ReceiveMessage";
            this.textBox_ReceiveMessage.ReadOnly = true;
            this.textBox_ReceiveMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ReceiveMessage.Size = new System.Drawing.Size(238, 102);
            this.textBox_ReceiveMessage.TabIndex = 10;
            // 
            // textBox_MessageDigestAfterDigestAlg
            // 
            this.textBox_MessageDigestAfterDigestAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MessageDigestAfterDigestAlg.Location = new System.Drawing.Point(6, 123);
            this.textBox_MessageDigestAfterDigestAlg.Multiline = true;
            this.textBox_MessageDigestAfterDigestAlg.Name = "textBox_MessageDigestAfterDigestAlg";
            this.textBox_MessageDigestAfterDigestAlg.ReadOnly = true;
            this.textBox_MessageDigestAfterDigestAlg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_MessageDigestAfterDigestAlg.Size = new System.Drawing.Size(238, 67);
            this.textBox_MessageDigestAfterDigestAlg.TabIndex = 12;
            // 
            // textBox_SendEncryptedMessageDigest
            // 
            this.textBox_SendEncryptedMessageDigest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SendEncryptedMessageDigest.Location = new System.Drawing.Point(9, 197);
            this.textBox_SendEncryptedMessageDigest.Multiline = true;
            this.textBox_SendEncryptedMessageDigest.Name = "textBox_SendEncryptedMessageDigest";
            this.textBox_SendEncryptedMessageDigest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SendEncryptedMessageDigest.Size = new System.Drawing.Size(238, 67);
            this.textBox_SendEncryptedMessageDigest.TabIndex = 7;
            // 
            // button_GetDigestFromReceivedMessage
            // 
            this.button_GetDigestFromReceivedMessage.Enabled = false;
            this.button_GetDigestFromReceivedMessage.Location = new System.Drawing.Point(250, 124);
            this.button_GetDigestFromReceivedMessage.Name = "button_GetDigestFromReceivedMessage";
            this.button_GetDigestFromReceivedMessage.Size = new System.Drawing.Size(163, 67);
            this.button_GetDigestFromReceivedMessage.TabIndex = 13;
            this.button_GetDigestFromReceivedMessage.Text = "Получить дайджест";
            this.button_GetDigestFromReceivedMessage.UseVisualStyleBackColor = true;
            this.button_GetDigestFromReceivedMessage.Click += new System.EventHandler(this.button_GetDigestFromReceivedMessage_Click);
            // 
            // textBox_ReceiveEncryptedMessageDigest
            // 
            this.textBox_ReceiveEncryptedMessageDigest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ReceiveEncryptedMessageDigest.Location = new System.Drawing.Point(250, 15);
            this.textBox_ReceiveEncryptedMessageDigest.Multiline = true;
            this.textBox_ReceiveEncryptedMessageDigest.Name = "textBox_ReceiveEncryptedMessageDigest";
            this.textBox_ReceiveEncryptedMessageDigest.ReadOnly = true;
            this.textBox_ReceiveEncryptedMessageDigest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ReceiveEncryptedMessageDigest.Size = new System.Drawing.Size(163, 103);
            this.textBox_ReceiveEncryptedMessageDigest.TabIndex = 11;
            this.textBox_ReceiveEncryptedMessageDigest.TabStop = false;
            // 
            // textBox_MessageDigestAfterDecryptionByPublicKey
            // 
            this.textBox_MessageDigestAfterDecryptionByPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MessageDigestAfterDecryptionByPublicKey.Location = new System.Drawing.Point(6, 196);
            this.textBox_MessageDigestAfterDecryptionByPublicKey.Multiline = true;
            this.textBox_MessageDigestAfterDecryptionByPublicKey.Name = "textBox_MessageDigestAfterDecryptionByPublicKey";
            this.textBox_MessageDigestAfterDecryptionByPublicKey.ReadOnly = true;
            this.textBox_MessageDigestAfterDecryptionByPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_MessageDigestAfterDecryptionByPublicKey.Size = new System.Drawing.Size(238, 67);
            this.textBox_MessageDigestAfterDecryptionByPublicKey.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Sign);
            this.groupBox2.Controls.Add(this.textBox_SendEncryptedMessageDigest);
            this.groupBox2.Controls.Add(this.button_Send);
            this.groupBox2.Controls.Add(this.textBox_MessageDigest);
            this.groupBox2.Controls.Add(this.button_GetDigestFromSendedMessage);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button_SelectKeys);
            this.groupBox2.Controls.Add(this.textBox_SendMessage);
            this.groupBox2.Controls.Add(this.buttonEncrypt);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 305);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сторона отправителя (Боб)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_MessageDigestAfterDecryptionByPublicKey);
            this.groupBox3.Controls.Add(this.textBox_ReceiveEncryptedMessageDigest);
            this.groupBox3.Controls.Add(this.button_GetDigestFromReceivedMessage);
            this.groupBox3.Controls.Add(this.textBox_MessageDigestAfterDigestAlg);
            this.groupBox3.Controls.Add(this.textBox_ReceiveMessage);
            this.groupBox3.Controls.Add(this.button_Verify);
            this.groupBox3.Controls.Add(this.buttonDecrypt);
            this.groupBox3.Location = new System.Drawing.Point(439, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 305);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сторона получателя (Алиса)";
            // 
            // button_Sign
            // 
            this.button_Sign.Location = new System.Drawing.Point(9, 88);
            this.button_Sign.Name = "button_Sign";
            this.button_Sign.Size = new System.Drawing.Size(237, 30);
            this.button_Sign.TabIndex = 3;
            this.button_Sign.Text = "Подписать";
            this.button_Sign.UseVisualStyleBackColor = true;
            this.button_Sign.Click += new System.EventHandler(this.button_Sign_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифроватьФайлToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // шифроватьФайлToolStripMenuItem
            // 
            this.шифроватьФайлToolStripMenuItem.Name = "шифроватьФайлToolStripMenuItem";
            this.шифроватьФайлToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.шифроватьФайлToolStripMenuItem.Text = "Шифровать файл";
            this.шифроватьФайлToolStripMenuItem.Click += new System.EventHandler(this.шифроватьФайлToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(864, 383);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressCoding);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Методы защиты информации. Лаб 5. Бекленищев Влад";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.ProgressBar progressCoding;
        private System.Windows.Forms.TextBox textBox_SendMessage;
        private System.Windows.Forms.Button button_SelectKeys;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Q;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Label label_Q;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Verify;
        private System.Windows.Forms.Button button_GetDigestFromSendedMessage;
        private System.Windows.Forms.TextBox textBox_MessageDigest;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_ReceiveMessage;
        private System.Windows.Forms.TextBox textBox_MessageDigestAfterDigestAlg;
        private System.Windows.Forms.TextBox textBox_SendEncryptedMessageDigest;
        private System.Windows.Forms.Button button_GetDigestFromReceivedMessage;
        private System.Windows.Forms.TextBox textBox_ReceiveEncryptedMessageDigest;
        private System.Windows.Forms.TextBox textBox_MessageDigestAfterDecryptionByPublicKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Sign;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифроватьФайлToolStripMenuItem;
    }
}

