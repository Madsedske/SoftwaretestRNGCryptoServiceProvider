using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwaretestRNGCryptoServiceProvider
{
    public class Encrypter
    {
        public string EncryptMethod(string input)
        {
            byte[] ascii = ASCIIEncoding.ASCII.GetBytes(input);
            string text = "";

            foreach (var characters in ascii)
            {
                var array = characters;
                array++;
                char character = (char)array;
                text += Char.ConvertFromUtf32(array);
            }                     
            return text;

        }

        public string DecryptMethod(string input)
        {
            byte[] ascii = ASCIIEncoding.ASCII.GetBytes(input);
            string text = "";

            foreach (var characters in ascii)
            {
                var array = characters;
                array--;
                char character = (char)array;
                text += Char.ConvertFromUtf32(array);
            }
            return text;
        }
    }
}
