using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> items = input.Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (!(command == "Even" || command == "Odd"))
            {


                string firstInput = command.Split()[0];
                var secondInput = command.Split()[1];

                if (firstInput == "Delete")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        items.Remove(int.Parse(secondInput));
                    }
                }
                else if (firstInput == "Insert")
                {
                   
                    var thirdInput = command.Split()[2];
                    items.Insert(int.Parse(thirdInput), int.Parse(secondInput));

                }
                 command = Console.ReadLine();
                               
            }

            
            
                for (int i = 0; i < items.Count; i++)
                {
                    if (command == "Odd" && items[i] % 2 == 1)
                    {

                    Console.Write($"{items[i]} ");
                }

                    else if (command == "Even" && items[i] % 2 == 0)
                    {
                 
                    Console.Write($"{items[i]} ");
                    }
                }
            Console.WriteLine();
        }
    }
}
