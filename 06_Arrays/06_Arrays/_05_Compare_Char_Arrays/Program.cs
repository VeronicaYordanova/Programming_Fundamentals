using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] secondArray = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            CompareTwoArrays(firstArray, secondArray);
        }

        public static void CompareTwoArrays(char[] firstArray, char[] secondArray)
        {
            int count = 0;
            int length = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
            }
            
            if (count == length)
            {
                if (firstArray.Length == secondArray.Length)
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                }
                else if(firstArray.Length > secondArray.Length)
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                    
                }
                else
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                }


            }
            else if (count > 0 && count != length)
            {
                if (firstArray[count] > secondArray[count])
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                }
                else
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                }

            }
            else if (count == 0)
            {
                if (firstArray[count] > secondArray[count])
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                }
                else
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                }
            }

        }
    }
}
