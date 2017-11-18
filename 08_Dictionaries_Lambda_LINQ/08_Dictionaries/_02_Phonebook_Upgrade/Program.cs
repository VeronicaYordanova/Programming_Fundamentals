using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string input = Console.ReadLine();


            while (input != "END")
            {
                string[] phoneParameters = input.Split(' ').ToArray();
                string command = phoneParameters[0];

                if (command == "A")
                {
                    string key = phoneParameters[1];
                    string value = phoneParameters[2];
                    // phonebook.Add(key, value);
                    phonebook[key] = value;

                }

                else if (command == "S")
                {
                    string key = phoneParameters[1];
                    if (phonebook.ContainsKey(key))
                    {
                        Console.WriteLine("{0} -> {1}", key, phonebook[key]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {phoneParameters[1]} does not exist.");
                    }
                }
                input = Console.ReadLine();

                if (input == "ListAll")
                {
                    foreach(var item in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                    
                }
                

            }


        }
    }
}