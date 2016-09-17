using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoProtection
{
    public class MySHA1
    {
        uint[] intermediateHash = new uint[]{
            0x67452301,
            0xEFCDAB89,
            0x98BADCFE,
            0x10325476,
            0xC3D2E1F0
        };

        /// <summary>
        /// Constants defined in SHA-1
        /// </summary>
        uint[] K = new uint[4]{       
           0x5A827999,
           0x6ED9EBA1,
           0x8F1BBCDC,
           0xCA62C1D6
        };

        /// <summary>
        /// Loop counter
        /// </summary>
        int t;

        /// <summary>
        /// Temporary word value
        /// </summary>
        uint temp;

        /// <summary>
        /// Word sequence 
        /// </summary>
        uint[] W = new uint[80];

        /// <summary>
        /// Word buffers
        /// </summary>
        uint A, B, C, D, E;

        String ZEROS = "00000000";

        byte[] messageBlock = new byte[64];

        byte[] ProcessTheBlock(byte[] messageBlock)
        {
            byte[] digest = null;

            for (t = 0; t < 16; t++)
            {
                W[t] = (uint)(messageBlock[t * 4] << 24);
                W[t] |= (uint)(messageBlock[t * 4 + 1] << 16);
                W[t] |= (uint)(messageBlock[t * 4 + 2] << 8);
                W[t] |= (uint)(messageBlock[t * 4 + 3]);
            }

            for (int outer = 0; outer < 16; outer++)
            {
                uint temp2 = 0;
                for (int inner = 0; inner < 4; inner++)
                {
                    temp2 = (uint)((messageBlock[outer * 4 + inner] & 0x000000FF) << (24 - inner * 8));
                    W[outer] = W[outer] | temp2;
                }
            }

            for (t = 16; t < 80; t++)
            {
                W[t] = rotateLeft(W[t - 3] ^ W[t - 8] ^ W[t - 14] ^ W[t - 16], 1);
            }

            A = intermediateHash[0];
            B = intermediateHash[1];
            C = intermediateHash[2];
            D = intermediateHash[3];
            E = intermediateHash[4];

            for (t = 0; t < 20; t++)
            {
                temp = (rotateLeft(A, 5) + ((B & C) | ((~B) & D)) + E + W[t] + K[0]);
                E = D;
                D = C;
                C = rotateLeft(B, 30);
                B = A;
                A = temp; ;
            }

            for (t = 20; t < 40; t++)
            {
                temp = (rotateLeft(A, 5) + (B ^ C ^ D) + E + W[t] + K[1]);
                E = D;
                D = C;
                C = rotateLeft(B, 30);
                B = A;
                A = temp;
            }

            for (t = 40; t < 60; t++)
            {
                temp = (rotateLeft(A, 5) + ((B & C) | (B & D) | (C & D)) + E + W[t] + K[2]);
                E = D;
                D = C;
                C = rotateLeft(B, 30);
                B = A;
                A = temp;
            }

            for (t = 60; t < 80; t++)
            {
                temp = (rotateLeft(A, 5) + (B ^ C ^ D) + E + W[t] + K[3]);
                E = D;
                D = C;
                C = rotateLeft(B, 30);
                B = A;
                A = temp;
            }

            intermediateHash[0] += A;
            intermediateHash[1] += B;
            intermediateHash[2] += C;
            intermediateHash[3] += D;
            intermediateHash[4] += E;

            return digest;
        }

        public String DigestIt(byte[] dataIn)
        {
            byte[] paddedData = PadTheMessage(dataIn);

            if (paddedData.Length % 64 != 0)
            {
                Console.WriteLine("Invalid padded data length.");
            }
            else
            {

                int passesReq = paddedData.Length / 64;
                byte[] work = new byte[64];

                for (int passCntr = 0; passCntr < passesReq; passCntr++)
                {
                    System.Array.Copy(paddedData, 64 * passCntr, work, 0, 64);
                    ProcessTheBlock(work);
                }
            }

            string sOut = "";
            for (int n = 0; n < 5; n++)
            {
                sOut += Convert.ToString(intermediateHash[n], 16);
            }

            return sOut;
        }

        private byte[] PadTheMessage(byte[] data)
        {
            int origLength = data.Length;
            int tailLength = origLength % 64;
            int padLength = 0;
            if ((64 - tailLength >= 9))
            {
                padLength = 64 - tailLength;
            }
            else
            {
                padLength = 128 - tailLength;
            }

            byte[] thePad = new byte[padLength];
            thePad[0] = (byte)0x80;
            long lengthInBits = origLength * 8;

            for (int cnt = 0; cnt < 8; cnt++)
            {
                thePad[thePad.Length - 1 - cnt] = (byte)((lengthInBits >> (8 * cnt)) & 0x00000000000000FF);
            }

            byte[] output = new byte[origLength + padLength];

            System.Array.Copy(data, 0, output, 0, origLength);
            System.Array.Copy(thePad, 0, output, origLength, thePad.Length);

            return output;

        }

        uint rotateLeft(uint value, int bits)
        {
            uint q = (value << bits) | (value >> (32 - bits));
            return q;
        }

        String padStr(String s)
        {
            if (s.Length > 8)
            {
                return s.Substring(s.Length - 8);
            }
            return ZEROS.Substring(s.Length) + s;
        }
    }
}
