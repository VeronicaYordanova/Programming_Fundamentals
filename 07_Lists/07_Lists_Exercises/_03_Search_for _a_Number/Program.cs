using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            List<int> firstItems = firstInput.Split(' ')
                .Select(int.Parse)
                .ToList();

            string secondInput = Console.ReadLine();
            List<int> secondItems = secondInput.Split(' ')
                .Select(int.Parse)
                .ToList();

            bool result = firstItems.Take(secondItems[0]).Skip(secondItems[1]).Contains(secondItems[2]);
            if (result)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
