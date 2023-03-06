using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwaretestRNGCryptoServiceProvider
{
    public class RandomGenerator
    {
        public void GenerateRandomNumber(int length)
        {
            Random rng = new Random();

            for (int i = 0; i < length; i++)
            {
                string number = "";

                for (int z = 0; z < 25; z++)
                {
                    number += Convert.ToString(rng.Next(100, 1000));
                }

                Console.WriteLine($"{i} : " + number);
            }
        }
    }
}
