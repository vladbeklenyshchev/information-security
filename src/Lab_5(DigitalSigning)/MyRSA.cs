using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoProtection
{
    public class MyRSA
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


        List<KeyValuePair<char, int>>[] alpha;
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
            int blockAmount = 0;
            blockAmount = strBytes.Length / n + 1;

            alpha = new List<KeyValuePair<char, int>>[blockAmount];
            for (int j = 0, i = 0, k = 0; j < alpha.Length; j += 1, k = 0)
            {
                alpha[j] = new List<KeyValuePair<char, int>>();
                while (k < n - 1 && i != strBytes.Length)
                {
                    alpha[j].Add(new KeyValuePair<char, int>(strBytes[i], k + 1));
                    i++;
                    k++;
                }
            }


            int temp = 0;
            string sOut = "";
            Random r = new Random();
            for (int j = 0, i = 0, k = 0; j < alpha.Length; j += 1, k = 0)
            {
                for (; k < n - 1; k++)
                {
                    temp = (ModuloPow(k + 1, e, (int)n));
                    if (temp == 0)
                        continue;
                    else
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
                    else
                    {
                        sOut += "|";
                    }
                    #endregion


                }
            }
            sOut = sOut.Remove(sOut.Length - 1);

            return sOut;
        }

        public string Decrypt(string strBytes)
        {
            int temp = 0;
            string sOut = "";

            string[] valuesFromString = strBytes.Split(new char[] { '+', '?', '=', '!', '-', '/', '|' });

            int[] iBytes = new int[valuesFromString.Length];

            try
            {
                for (int i = 0; i < iBytes.Length; i++)
                    iBytes[i] = Convert.ToInt32(valuesFromString[i]);

                for (int j = 0, i = 0, k = 0; j < alpha.Length; j += 1, k = 0)
                {
                    while (k < n - 1 && i != iBytes.Length)
                    {
                        temp = ModuloPow(iBytes[i], d, (int)n);
                        sOut += alpha[j].Find(x => x.Value == temp).Key;
                        i++;
                        k++;

                    }
                    /*if (sOut[sOut.Length - 1] == '0')
                    {
                        sOut.Remove(sOut.Length - 1);
                    }*/
                }

            }

            catch (System.FormatException ex)
            {
                
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
}
