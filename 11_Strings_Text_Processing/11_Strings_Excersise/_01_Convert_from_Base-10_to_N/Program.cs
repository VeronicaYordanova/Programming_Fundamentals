using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01_Convert_from_Base_10_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> numbers = new List<BigInteger>();
            numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();

            int n = (int)numbers[0];
            BigInteger number = numbers[1];

            BigInteger remainder;
            string result = String.Empty;

            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    remainder = number % n;
                    number /= n;

                    result = remainder.ToString() + result;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
