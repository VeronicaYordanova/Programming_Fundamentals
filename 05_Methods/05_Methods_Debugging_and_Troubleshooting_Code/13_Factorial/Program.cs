﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
        
            for (int i = 1; i <=number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
