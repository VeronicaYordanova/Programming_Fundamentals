using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

            int count = 0;
            int number = 0;
            int tempNumber = 0;
            int maxNumber = 0;
            int maxCount = 0;

            for (int j = 0; j < array.Length; j++)
            {
                
                tempNumber = array[j];
                count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    
                    if (array[i] == tempNumber)
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
            Console.WriteLine(maxNumber);
        }
    }
}
