using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    len++;
                }
                else
                {
                    start = i;
                    len = 1;
                }

                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {

                Console.Write($"{array[i]} ");

            }

            Console.WriteLine();
        }
    }
}