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
            progressCoding.Value = 0;
            progressCoding.Minimum = 0;
            progressCoding.Maximum = 100;
            toolTip1.InitialDelay = 10;
            toolTip1.SetToolTip(this.textBoxPublicKey, "Формат для ввода ключа: { ключ, результат_умножения_p_q}");
            toolTip1.SetToolTip(this.textBoxPrivateKey, "Формат для ввода ключа: { ключ, результат_умножения_p_q}");

            myRSA = new MyRSA();
        }

        class MyRSA
        {
            #region fields

            private struct ExtendedEuclideanResult
            { 
                public int u1;
                public double u2;
                public double gcd;
            }

            int n = 0;
            int m = 0;
            
            // for private key
            int d = 0;

            // for public key
            int e = 0;


            List<KeyValuePair<char, int>> alpha = new List<KeyValuePair<char, int>>();
            #endregion

            #region properties
            public int P
            {
                get;
                set;
            }

            public int Q
            {
                get;
                set;
            }
            #endregion

            public MyRSA()
            {

            }

            #region methods

            
            public void FindKeys()
            {
                Random random = new Random();
                n = Modulus();
                m = EylerFunction();
                List<int> possibleE = GetAllPossibleE(m);
                do
                {
                    e = possibleE[random.Next(0, possibleE.Count)];
                    d = ExtendedEuclide((int)(e % m), (int)m).u1;
                } while (this.d < 0 || e == d || d > m);
            }

            private int Modulus()
            {
                n = P * Q;
                return n;
            }

            private int EylerFunction()
            {
                m = (P - 1) * (Q - 1);
                return m;
            }

            public string Encrypt(string strBytes)
            {
                alpha = new List<KeyValuePair<char, int>>();
                for(int i = 0; i < n && i < strBytes.Length; i++)
                {
                    alpha.Add(new KeyValuePair<char, int>(strBytes[i], i+1));
                }

                int temp = 0;
                string sOut = "";
                Random r = new Random();
                for (int i = 0; i < strBytes.Length; i++)
                {
                    temp = (ModuloPow(i+1, e, (int)n));
                    sOut += temp;

                    #region generate random separators
                    int tmpRand = r.Next(8);
                    if (tmpRand == 0)
                    {
                        sOut += "+";
                    }
                    else if (tmpRand == 1)
                    {
                        sOut += "?";
                    }
                    else if (tmpRand == 2)
                    {
                        sOut += "=";
                    }
                    else if (tmpRand == 3)
                    {
                        sOut += "!";
                    }
                    else if (tmpRand == 4)
                    {
                        sOut += "-";
                    }
                    else if (tmpRand == 5)
                    {
                        sOut += "/";
                    }
                    else if (tmpRand == 6)
                    {
                        sOut += "\\";
                    }
                    else
                    {
                        sOut += "|";
                    }
                    #endregion
                }
                sOut = sOut.Remove(sOut.Length - 1);

                return sOut;
            }

            public string Decrypt(string strBytes)
            {
                int temp = 0;
                string sOut = "";

                string[] valuesFromString = strBytes.Split(new char[]{'+','?','=','!','-','/','\\','|'});

                int[] iBytes = new int[valuesFromString.Length];
                
                try
                {
                    for (int i = 0; i < iBytes.Length; i++)
                        iBytes[i] = Convert.ToInt32(valuesFromString[i]);
                    for (int i = 0; i < iBytes.Length; i++)
                    {
                        temp = ModuloPow(iBytes[i], d, (int)n);
                        sOut += alpha.Find(x => x.Value == temp).Key;
                    }
                }
                
                catch (System.FormatException ex)
                {
                    MessageBox.Show("Входная строка имеет неверный формат.");
                }
                
                return sOut;
            }

            int ModuloPow(int value, int pow, int modulo)
            {
                double result = value;
                for (int i = 0; i < pow - 1; i++)
                {
                    result = (result * value) % modulo;
                }
                return (int)(result);
            }
            
            
            List<int> GetAllPossibleE(double phi)
            {
                List<int> result = new List<int>();

                for (int i = 2; i < phi; i++)
                {
                    if (ExtendedEuclide(i, (int)phi).gcd == 1)
                    {
                        result.Add(i);
                    }
                }

                return result;
            }

            //http://landrina.ru/development/c-realizaciya-rasshirennogo-algoritma-evklida/
            /// <summary>
            /// u1 * a + u2 * b = u3
            /// </summary>
            /// <param name="a">Число a</param>
            /// <param name="b">Модуль числа</param>
            private ExtendedEuclideanResult ExtendedEuclide(int a, int b)
            {
                int u1 = 1;
                int u3 = a;
                int v1 = 0;
                int v3 = b;

                while (v3 > 0)
                {
                    int q0 = u3 / v3;
                    int q1 = u3 % v3;

                    int tmp = v1 * q0;
                    int tn = u1 - tmp;
                    u1 = v1;
                    v1 = tn;

                    u3 = v3;
                    v3 = q1;
                }

                double tmp2 = u1 * (a);
                tmp2 = u3 - (tmp2);
                double res = tmp2 / (b);

                ExtendedEuclideanResult result = new ExtendedEuclideanResult()
                {
                    u1 = u1,
                    u2 = res,
                    gcd = u3
                };

                return result;
            }

            public string GetPublicKey()
            {
                return String.Format("{{{0}, {1}}}", e, n);
            }

            public string GetPrivateKey()
            {
                return String.Format("{{{0}, {1}}}", d, n);
            }

            public void SetPublicKey(string key)
            {
                string[] splitStrings = key.Split(new char[]{'{', ',', '}'});
                int[] parseArray = new int[2];

                int i = 0;
                foreach (var x in splitStrings)
                {
                    try
                    {
                        parseArray[i] = Convert.ToInt32(x);
                        i++;
                    }
                    catch (System.FormatException ex)
                    {

                    }
                    catch (System.IndexOutOfRangeException ex)
                    {
                        break;
                    }
                }

                e = parseArray[0];
                n = parseArray[1];
            }

            public void SetPrivateKey(string key)
            {
                string[] splitStrings = key.Split(new char[] { '{', ',', '}' });
                int[] parseArray = new int[2];

                int i = 0;
                foreach (var x in splitStrings)
                {
                    try
                    {
                        parseArray[i] = Convert.ToInt32(x);
                        i++;
                    }
                    catch (System.FormatException e)
                    {

                    }
                    catch (System.IndexOutOfRangeException e)
                    {
                        break;
                    }
                }
                d = parseArray[0];
                n = parseArray[1];
            }
            #endregion
        }

        MyRSA myRSA;

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            progressCoding.Value = 0;
            
            if (textBoxPrivateKey.Text == "" && textBoxPublicKey.Text == "")
            {
                if (textBox_P.Text != "" && textBox_Q.Text != "")
                {
                    myRSA.P = Convert.ToInt32(textBox_P.Text);
                    myRSA.Q = Convert.ToInt32(textBox_Q.Text);
                    myRSA.FindKeys();
                    textBoxCipher.Text = myRSA.Encrypt(textBoxForInput.Text);
                }
            }
            else
            {
                myRSA.SetPublicKey(textBoxPublicKey.Text);
                myRSA.SetPrivateKey(textBoxPrivateKey.Text);
                textBoxCipher.Text = myRSA.Encrypt(textBoxForInput.Text);
            }
            progressCoding.Value += 100;
            buttonDecrypt.Enabled = true;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            progressCoding.Value = 0;
            
            if(textBoxCipher.Text != "")
                textBoxResult.Text = myRSA.Decrypt(textBoxCipher.Text);

            progressCoding.Value += 100;
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

        }

        private void comboBoxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_SelectKeys_Click(object sender, EventArgs e)
        {
            progressCoding.Value = 0;
            myRSA = new MyRSA();
            myRSA.P = Convert.ToInt32(textBox_P.Text);
            myRSA.Q = Convert.ToInt32(textBox_Q.Text);
            progressCoding.Value += 50;
            myRSA.FindKeys();
            
            progressCoding.Value += 50;
            buttonEncrypt.Enabled = true;
            /*buttonDecrypt.Enabled = true;*/
            textBoxPrivateKey.Enabled = true;
            textBoxPublicKey.Enabled = true;
            textBoxPublicKey.Text = myRSA.GetPublicKey();
            textBoxPrivateKey.Text = myRSA.GetPrivateKey();
        }

        private void button_LoadPublicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDialog = new OpenFileDialog();
            oDialog.Filter = "txt files (.txt) |.TXT | all files (*.*) |*.*";

            if (oDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader myStream = new StreamReader(oDialog.FileName))
                    {
                        textBoxPublicKey.Text = myStream.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button_LoadPrivateKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDialog = new OpenFileDialog();
            oDialog.Filter = "txt files (.txt) |.TXT | all files (*.*) |*.*";

            if (oDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader myStream = new StreamReader(oDialog.FileName))
                    {
                        textBoxPrivateKey.Text = myStream.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_DownloadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDialog = new OpenFileDialog();
            oDialog.Filter = "txt files (.txt) |.TXT | all files (*.*) |*.*";

            if (oDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader myStream = new StreamReader(oDialog.FileName))
                    {
                        textBoxForInput.Text = myStream.ReadToEnd();
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
