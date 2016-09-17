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
using System.Security.Cryptography;

namespace InfoProtection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            progressCoding.Value = 0;
            progressCoding.Minimum = 0;
            progressCoding.Maximum = 100;

            myRSA = new MyRSA();
        }

        MyRSA myRSA;
        MySHA1 sha1;

        private bool checkForEnable = false;

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            progressCoding.Value = 0;

            if (textBox_P.Text != "" && textBox_Q.Text != "")
            {
                myRSA.P = Convert.ToInt32(textBox_P.Text);
                myRSA.Q = Convert.ToInt32(textBox_Q.Text);
                myRSA.FindKeys();
                // encrypt digest
                textBox_SendEncryptedMessageDigest.Text = myRSA.Encrypt(textBox_MessageDigest.Text);
                button_Send.Enabled = true;
            }

            progressCoding.Value += 100;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            progressCoding.Value = 0;

            if(textBox_ReceiveEncryptedMessageDigest.Text != "")
                textBox_MessageDigestAfterDecryptionByPublicKey.Text = 
                    myRSA.Decrypt(textBox_ReceiveEncryptedMessageDigest.Text);

            progressCoding.Value += 100;
            button_Verify.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            progressCoding.Value = 0;
            
        }

        private void button_SelectKeys_Click(object sender, EventArgs e)
        {
            if (checkForEnable)
            {
                button_GetDigestFromSendedMessage.Enabled = true;
            }

            progressCoding.Value = 0;
            myRSA = new MyRSA();
            myRSA.P = Convert.ToInt32(textBox_P.Text);
            myRSA.Q = Convert.ToInt32(textBox_Q.Text);
            progressCoding.Value += 50;
            myRSA.FindKeys();
            
            progressCoding.Value += 50;
            checkForEnable = true;
        }

        private void button_GetDigestFromSendedMessage_Click(object sender, EventArgs e)
        {
            byte[] fileData = Encoding.ASCII.GetBytes(textBox_SendMessage.Text);
            sha1 = new MySHA1();
            // get digest
            textBox_MessageDigest.Text = sha1.DigestIt(fileData);
            buttonEncrypt.Enabled = true;
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            textBox_ReceiveMessage.Text = textBox_SendMessage.Text;
            textBox_ReceiveEncryptedMessageDigest.Text = textBox_SendEncryptedMessageDigest.Text;
            // also Bob sends public key for Alice

            button_GetDigestFromReceivedMessage.Enabled = true;
        }

        private void button_GetDigestFromReceivedMessage_Click(object sender, EventArgs e)
        {
            byte[] fileData = Encoding.ASCII.GetBytes(textBox_ReceiveMessage.Text);
            sha1 = new MySHA1();
            // get digest
            textBox_MessageDigestAfterDigestAlg.Text = sha1.DigestIt(fileData);
            buttonDecrypt.Enabled = true;
        }

        private void button_Verify_Click(object sender, EventArgs e)
        {
            if (textBox_MessageDigestAfterDigestAlg.Text == textBox_MessageDigestAfterDecryptionByPublicKey.Text)
            {
                MessageBox.Show("Сообщение передано корректно!");
            }
            else
                MessageBox.Show("Сообщение было изменено!");
        }

        private void button_Sign_Click(object sender, EventArgs e)
        {
            if (checkForEnable)
            {
                button_GetDigestFromSendedMessage.Enabled = true;
            }

            textBox_SendMessage.Text += "\r\nName: Bob\r\nData:" + DateTime.Now;

            checkForEnable = true;
        }

        private void шифроватьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDialog = new OpenFileDialog();
            oDialog.Filter = "txt files (.txt) |.TXT | all files (*.*) |*.*";

            if (oDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader myStream = new StreamReader(oDialog.FileName))
                    {
                        textBox_SendMessage.Text = myStream.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
