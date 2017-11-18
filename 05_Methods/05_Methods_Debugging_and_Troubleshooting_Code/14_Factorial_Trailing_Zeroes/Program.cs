using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14_Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            GetTrailingZeroes(factorial);
        }
        static void GetTrailingZeroes(BigInteger num)
        {

            BigInteger zero = 0;
            while (num % 10 == 0)
            {
                num = num / 10;
                zero++;
            }
            Console.WriteLine(zero);
        }
    }
}
