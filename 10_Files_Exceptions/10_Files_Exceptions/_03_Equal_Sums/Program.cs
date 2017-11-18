using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            File.WriteAllLines("input.txt", numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += int.Parse(numbers[j]);
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += int.Parse(numbers[j]);
                }

                if (leftSum == rightSum)
                {
                    File.WriteAllText("output.txt", i.ToString());
                    return;
                }
            }

            File.WriteAllText("output.txt", "no");
        }
    }
}