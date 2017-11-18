using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            List<string> items = values.Split(' ').ToList();
            File.WriteAllLines("input.txt", items);
            File.WriteAllText("output.txt", string.Empty);

            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;


            for (int i = 1; i < items.Count; i++)
            {
                if (items[i] == items[i - 1])
                {
                    len++;

                    if (len > bestLen)
                    {
                        bestStart = i - 1;
                        bestLen = len;
                    }
                }
                else
                {

                    len = 1;
                }


            }

            for (int i = 0; i < bestLen; i++)
            {

                // nums.Add(int.Parse(items[i]));
                File.WriteAllText("output.txt", $"{items[bestStart]} ");

               
            }
            Console.WriteLine();


        }

    }
}