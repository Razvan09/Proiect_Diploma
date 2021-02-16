using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Proiect_Diploma
{
    class Clasa_AES
    {
        public static string Key;
        public static string IV = GenerareCheie(16);

        public static string Criptare(string text)
        {
            byte[] textclar = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform criptare = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] textcriptat = criptare.TransformFinalBlock(textclar, 0, textclar.Length);
            criptare.Dispose();
            return Convert.ToBase64String(textcriptat);
        }

        public static void setKey()
        {
            Key = GenerareCheie(16);
        }

        public static void setIV()
        {
            IV = GenerareCheie(16);
        }

        public static string Decriptare(string textcriptat)
        {
            byte[] octeticriptati = Convert.FromBase64String(textcriptat);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform decriptare = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] txtdecriptat = decriptare.TransformFinalBlock(octeticriptati, 0, octeticriptati.Length);
            decriptare.Dispose();
            return System.Text.ASCIIEncoding.ASCII.GetString(txtdecriptat);
            
        }
        byte[] cheie = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
        
        public static string GenerareCheie(int lungime)
        {
            const string caractere = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvxwyz0123456789";
            var aleator = new Random();
            return new string(Enumerable.Repeat(caractere, lungime).Select(s => s[aleator.Next(s.Length)]).ToArray());

        }
    }
}
