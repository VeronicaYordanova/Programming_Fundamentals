using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            Dictionary<string, int> resources = new Dictionary<string, int>();

         

            while (resource != "stop")
            {
                int quantity = 0;
                quantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }
                resource = Console.ReadLine();
            }
            File.WriteAllText("output.txt", string.Empty);

            foreach (var item in resources)
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}{Environment.NewLine}");
            }
        }
    }
}
