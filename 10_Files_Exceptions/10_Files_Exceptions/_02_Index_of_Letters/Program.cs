using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {


            var alphabet = "abcdefjhijklmnopqrstuvwxyz".ToCharArray();
            var letters = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToArray();

            File.WriteAllLines("input.txt", letters);
            File.WriteAllText("output.txt", string.Empty);

            foreach (var letter in letters)
            {
                File.AppendAllText("output.txt", $"{letter} -> {Array.IndexOf(alphabet, char.Parse(letter))}{Environment.NewLine}");
            }

        }

    }
}
