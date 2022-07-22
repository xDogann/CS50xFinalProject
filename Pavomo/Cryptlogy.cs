using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavomo
{
    class Cryptlogy
    {
        public static string Encryption(string text, int key)
        {
            char[] x = text.ToCharArray();
            string encryptedText = null;

            foreach (char item in x)
            {
                encryptedText += Convert.ToChar(item + key);
            }
            return encryptedText;
        }
        public static string Decryption(string text, int key)
        {
            char[] x = text.ToCharArray();
            string decryptedText = null;

            foreach (char item in x)
            {
                decryptedText += Convert.ToChar(item - key);
            }
            return decryptedText;
        } 
    }
}
