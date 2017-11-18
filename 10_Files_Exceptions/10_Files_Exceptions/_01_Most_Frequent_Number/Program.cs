using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string[] array = Console.ReadLine().Split().ToArray();
            File.WriteAllLines("input.txt", array);

            int count = 0;
            int number = 0;
            int tempNumber = 0;
            int maxNumber = 0;
            int maxCount = 0;

            for (int j = 0; j < array.Length; j++)
            {

                tempNumber = int.Parse(array[j]);
                count = 0;
                for (int i = 0; i < array.Length; i++)
                {

                    if (int.Parse(array[i]) == tempNumber)
                    {
                        count++;
                        number = tempNumber;
                    }

                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxNumber = tempNumber;
                }
            }
            File.WriteAllText("output.txt", $"The number {maxNumber.ToString()} is the most frequent.");
        }
    }
}
