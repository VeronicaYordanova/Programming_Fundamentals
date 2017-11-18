using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Console.ReadLine()
                .Split()
                .Select(a => int.Parse(new string(a.Reverse().ToArray())))
                .Sum();
            Console.WriteLine(input);
       
        }
    }
}
