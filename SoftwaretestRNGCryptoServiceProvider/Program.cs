using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwaretestRNGCryptoServiceProvider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Runtimes for crypto?");
            int cryptoLength = Convert.ToInt32(Console.ReadLine());
            RNGCrypto crypto = new RNGCrypto();
            crypto.GenerateRandom(cryptoLength);

            Console.WriteLine("Runtimes for random?");
            int randomLength = Convert.ToInt32(Console.ReadLine());
            RandomGenerator random = new RandomGenerator();
            random.GenerateRandomNumber(randomLength);

            Console.WriteLine("What word should be encrypted?");
            string wordEncrypt = Console.ReadLine();
            Encrypter encrypter = new Encrypter();
            Console.WriteLine(encrypter.EncryptMethod(wordEncrypt));

            Console.WriteLine("What word should be decrypted?");
            string wordDecrypt = Console.ReadLine();
            Encrypter decrypter = new Encrypter();
            Console.WriteLine(decrypter.DecryptMethod(wordDecrypt));


            Console.ReadKey();
        }
    }
}
