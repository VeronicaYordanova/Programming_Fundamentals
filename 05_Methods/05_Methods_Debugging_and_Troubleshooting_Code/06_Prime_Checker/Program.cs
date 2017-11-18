using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = false;
            isPrime = IsPrime(isPrime);
            Console.WriteLine(isPrime);

        }

        static bool IsPrime(bool isPrime)
        {
            long number = long.Parse(Console.ReadLine());
            number = Math.Abs(number);
            double range = Math.Sqrt(number);
            isPrime = true;

            if (number < 2)
            {
                isPrime = false;
                return isPrime;
            }

            else 
            {

                for (int i = 2; i <= range; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                return isPrime;
            }
            else
            {
                return isPrime;
            }
        }
    }
}