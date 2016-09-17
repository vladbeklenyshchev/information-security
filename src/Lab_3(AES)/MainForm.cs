using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InfoProtection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxAlgorithm.SelectedIndex = 0;
            progressCoding.Value = 0;
            progressCoding.Minimum = 0;
            progressCoding.Maximum = 100;
        }

        MyAes aes = new MyAes();

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            progressCoding.Value = 0;
            if (textBoxForInput.TextLength != 0)
            {
                byte[] original = Encoding.ASCII.GetBytes(textBoxForInput.Text);

                int method = comboBoxAlgorithm.SelectedIndex;

                if (method == 0)
                    method = 16;
                else if (method == 1)
                    method = 24;
                else if (method == 2)
                    method = 32;
                
                progressCoding.Value += 20;

                byte[] encryptedArray = aes.Encrypt(original, textBoxKey.Text, method);
                progressCoding.Value += 70;

                textBoxCipher.Text = Convert.ToBase64String(encryptedArray);
                progressCoding.Value += 10;
            }
            else MessageBox.Show("Введите данные для зашифровывания!");
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            progressCoding.Value = 0;
            if (textBoxCipher.TextLength != 0)
            {
                byte[] encryptedArray = Convert.FromBase64String(textBoxCipher.Text);

                int method = comboBoxAlgorithm.SelectedIndex;

                if (method == 0)
                    method = 16;
                else if (method == 1)
                    method = 24;
                else if (method == 2)
                    method = 32;

                progressCoding.Value += 20;

                byte[] decryptedArray = aes.Decrypt(encryptedArray, textBoxKey.Text, method);
                progressCoding.Value += 70;

                textBoxResult.Text = Encoding.ASCII.GetString(decryptedArray);
                progressCoding.Value += 10;
            }
            else MessageBox.Show("Введите данные для расшифровывания!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            progressCoding.Value = 0;
            textBoxForInput.Text = "";
            textBoxCipher.Text = "";
            textBoxResult.Text = "";
        }

        private void textBoxKey_Leave(object sender, EventArgs e)
        {
            if ((textBoxKey.TextLength != 16 )
                && (textBoxKey.TextLength != 24) 
                && (textBoxKey.TextLength != 32) 
            )
            {
                MessageBox.Show("Ключ должен быть длиною 16, 24 или 32 символа!");
            }
        }

        private void comboBoxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlgorithm.SelectedIndex == 0)
            {
                if (textBoxKey.TextLength == 24)
                {
                    textBoxKey.Text = textBoxKey.Text.Remove(16, 8);
                }
                else if (textBoxKey.TextLength == 32)
                {
                    textBoxKey.Text = textBoxKey.Text.Remove(16, 16);
                }
            }
            else if (comboBoxAlgorithm.SelectedIndex == 1)
            {
                if (textBoxKey.TextLength == 16)
                {
                    textBoxKey.Text += "DefaultK";
                }
                else if (textBoxKey.TextLength == 32)
                {
                    textBoxKey.Text = textBoxKey.Text.Remove(24, 8);
                }
            }
            else if (comboBoxAlgorithm.SelectedIndex == 2)
            {
                if (textBoxKey.TextLength == 16)
                {
                    textBoxKey.Text += "DefaultKeyForAes";
                }
                else if (textBoxKey.TextLength == 24)
                {
                    textBoxKey.Text += "DefaultK";
                }
            }
        }
    }
}
