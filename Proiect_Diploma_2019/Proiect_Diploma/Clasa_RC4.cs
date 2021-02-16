using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Proiect_Diploma
{
    class Clasa_RC4
    {

        private const int N = 256; // valoare pentru suma modulo 256
        private int[] s;        // vectorul s 
        private string cheie;  // cheia pentru criptare si decriptare 
        private string text;  // textul de criptat

        public Clasa_RC4(string cheie, string text)
        {
            this.cheie = cheie;
            this.text = text;
        }

        public Clasa_RC4(string cheie)
        {
            this.cheie = cheie;
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public string Cheie
        {
            get { return cheie; }
            set { cheie = value; }
        }
        public string CriptDecript()
        {
            InitializareRC4();

            int i = 0, j = 0, k = 0;

            StringBuilder cifru = new StringBuilder();

            for (int a = 0; a < text.Length; a++)
            {
                i = (i + 1) % N;
                j = (j + s[i]) % N;
                int aux = s[i];
                s[i] = s[j];
                s[j] = aux;

                k = s[(s[i] + s[j]) % N];
                int val = ((int)text[a]) ^ k; //se face xor 
                cifru.Append(Convert.ToChar(val));
            }
            return cifru.ToString();
        }

        private void InitializareRC4()
        {
            s = new int[N];
            int[] t = new int[N];  //vectorul t pentru cheie 
            int n = cheie.Length;
            for (int i = 0; i < N; i++)
            {        
                t[i] = (int)cheie[i % n];
                s[i] = i;
            }

            int j = 0;         
            for (int i = 0; i < N; i++)
            {
                j = (j + s[i] + t[i]) % N;
                int aux = s[i];
                s[i] = s[j];
                s[j] = aux;
            }
        }
        public static string ConvBininHex(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                int v = Convert.ToInt32(str[i]);
                sb.Append(string.Format("{0:X2}", v));
            }
            return sb.ToString();
        }
        public static string ConvHexinBin(string hexStr)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hexStr.Length; i += 2)
            {
                int n = Convert.ToInt32(hexStr.Substring(i, 2), 16);
                sb.Append(Convert.ToChar(n));
            }
            return sb.ToString();
        }

        public static string generareCheie(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public int getTextLength()
        {
            return text.Length;
        }
        

        
    }
}