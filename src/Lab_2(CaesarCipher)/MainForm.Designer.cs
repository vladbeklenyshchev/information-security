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
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxShift = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.progressCoding = new System.Windows.Forms.ProgressBar();
            this.textBoxForInput = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(12, 162);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(237, 31);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxShift
            // 
            this.textBoxShift.Location = new System.Drawing.Point(54, 116);
            this.textBoxShift.Name = "textBoxShift";
            this.textBoxShift.Size = new System.Drawing.Size(38, 20);
            this.textBoxShift.TabIndex = 1;
            this.textBoxShift.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сдвиг:";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(255, 162);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(237, 31);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // progressCoding
            // 
            this.progressCoding.Location = new System.Drawing.Point(12, 142);
            this.progressCoding.Name = "progressCoding";
            this.progressCoding.Size = new System.Drawing.Size(722, 14);
            this.progressCoding.TabIndex = 6;
            // 
            // textBoxForInput
            // 
            this.textBoxForInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxForInput.Multiline = true;
            this.textBoxForInput.Name = "textBoxForInput";
            this.textBoxForInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForInput.Size = new System.Drawing.Size(237, 85);
            this.textBoxForInput.TabIndex = 0;
            this.textBoxForInput.Text = "Сьешь еще этих мягких, французских булочек, да выпей чаю.";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(497, 162);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(237, 31);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить окна";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(255, 12);
            this.textBoxCipher.Multiline = true;
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCipher.Size = new System.Drawing.Size(237, 85);
            this.textBoxCipher.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(498, 12);
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
            this.label2.Location = new System.Drawing.Point(105, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Область для ввода данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Зашифрованные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Результат дешифровки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(746, 205);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxCipher);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxForInput);
            this.Controls.Add(this.progressCoding);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShift);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Методы защиты информации. Лаб 2. Бекленищев Влад";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ProgressBar progressCoding;
        private System.Windows.Forms.TextBox textBoxForInput;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

