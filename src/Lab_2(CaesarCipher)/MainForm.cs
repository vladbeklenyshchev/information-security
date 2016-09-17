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
        }

        class CaesarCipher
        {
            // count of unicode chars
            private int n = 65536;

            public int Shift
            {
                get;
                set;
            }

            public string Encode(string sInput)
            {
                string sOutput = "";
                for (int i = 0; i < sInput.Length; i++)
                {
                    sOutput += (Convert.ToChar(((sInput[i]) + Shift) % n));
                }
                return sOutput;
            }

            public string Encode(string sInput, ProgressBar progressCoding)
            {
                string sOutput = "";
                for (int i = 0; i < sInput.Length; i++)
                {
                    sOutput += (Convert.ToChar(((sInput[i]) + Shift) % n));
                    progressCoding.Value++;
                }
                return sOutput;
            }

            public string Decode(string sInput)
            {
                string sOutput = "";
                for (int i = 0; i < sInput.Length; i++)
                    sOutput += (Convert.ToChar(((sInput[i]) - Shift + n) % n));
                return sOutput;
            }

            public string Decode(string sInput, ProgressBar progressCoding)
            {
                string sOutput = "";
                for (int i = 0; i < sInput.Length; i++)
                {
                    sOutput += (Convert.ToChar(((sInput[i]) - Shift + n) % n));
                    progressCoding.Value++;
                }
                return sOutput;
            }
        }

        CaesarCipher newCipher;

        delegate string Func(string s);

        void DoFunction(Func f, CaesarCipher newCipher, TextBox textBoxInput, TextBox textBoxOutput)
        {
            string sInput = "";
            string sOutput = "";
            sInput = textBoxInput.Text;
            newCipher.Shift = int.Parse(textBoxShift.Text);
            progressCoding.Value = 0;
            progressCoding.Maximum = sInput.Length;
            sOutput = f(sInput);
            textBoxOutput.Text = sOutput;
        }

         
        
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxForInput.TextLength != 0)
            {
                newCipher = new CaesarCipher();
                DoFunction(newCipher.Encode, newCipher,textBoxForInput,textBoxCipher);
            }
            else MessageBox.Show("Введите данные для зашифровывания!");
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxCipher.TextLength != 0)
            {
                newCipher = new CaesarCipher();
                DoFunction(newCipher.Decode, newCipher, textBoxCipher, textBoxResult);
                
            }
            else MessageBox.Show("Введите данные для расшифровывания!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxForInput.Text = "";
            textBoxCipher.Text = "";
            textBoxResult.Text = "";
        }
    }
}
