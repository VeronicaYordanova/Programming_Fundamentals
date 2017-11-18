using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int leftCount = CheckLeftToRight(firstArray, secondArray);
            int rightCount = CheckRightToLeft(firstArray, secondArray);

            int largestCommon = Math.Max(leftCount, rightCount);

            Console.WriteLine(largestCommon);

        }
        public static int CheckLeftToRight(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            int lenght = Math.Min(firstArray.Length, secondArray.Length);
            for (int i = 0; i < lenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            return count;
        }

        public static int CheckRightToLeft(string[] firstArray, string[] secondArray)
        {


            int count = 0;
            int lenght = Math.Min(firstArray.Length, secondArray.Length);

            Array.Reverse(firstArray);
            secondArray = secondArray.Reverse().ToArray();

            for (int i = 0; i < lenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            return count;
        }

    }
}