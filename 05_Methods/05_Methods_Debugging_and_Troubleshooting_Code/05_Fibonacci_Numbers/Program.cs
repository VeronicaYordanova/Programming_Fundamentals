using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(Fibonacci(n));
            }

        }
        private static int Fibonacci(int n)
        {
            var f1 = 0;
            var f2 = 1;
            var next = 0;
            for (int i = 1; i <= n; i++)
            {
                next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
            return next;
        }

    }
}
