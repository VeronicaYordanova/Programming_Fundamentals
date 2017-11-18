using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02_Convert_from_Base_N_to_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> numbers = new List<BigInteger>();
            numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();

            int n = (int)numbers[0];
            BigInteger number = numbers[1];

            
            var result = new BigInteger();
         
            var count = 0;

            while (number > 0)
            {
                BigInteger remainder = number % 10;
                var num = BigInteger.Multiply(remainder, BigInteger.Pow(n, count));

                result += num;
                number /= 10;
                count++;
            }

            Console.WriteLine(result);

        }
    }
}
