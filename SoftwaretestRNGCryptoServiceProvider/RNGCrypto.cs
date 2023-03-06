using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoftwaretestRNGCryptoServiceProvider
{
    public class RNGCrypto
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        
        public void GenerateRandom(int length) 
        {
            byte[] data = new byte[50];

            for (int i = 0; i < length; i++)
            {
                rngCsp.GetBytes(data);

                string value = Convert.ToBase64String(data);

               // byte base64 = Convert.ToBase64String(value);

                Console.WriteLine($"{i} : " + value);
            }
        }
    }
}
