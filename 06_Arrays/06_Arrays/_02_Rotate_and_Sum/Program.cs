using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digitsInArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int numberOfRotation = int.Parse(Console.ReadLine());
            int[] sum = new int[digitsInArray.Length];

            Rotation(digitsInArray, numberOfRotation, sum);
        }

        static void Rotation(int[] digitsInArray, int numberOfRotation, int[] sum)
        {


            for (int r = 0; r < numberOfRotation; r++)
            {
                var last = digitsInArray[digitsInArray.Length - 1];
                for (int i = digitsInArray.Length - 1; i > 0; i--)
                {
                    digitsInArray[i] = digitsInArray[i - 1];
                }
                digitsInArray[0] = last;

                for (int k = 0; k < digitsInArray.Length; k++)
                {
                    sum[k] += digitsInArray[k];
                }
            }
            Console.Write(string.Join(" ", sum));

        }
    }
}
