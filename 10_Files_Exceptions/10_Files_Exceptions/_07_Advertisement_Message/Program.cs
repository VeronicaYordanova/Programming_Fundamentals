using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07_Advertisement_Message
{
    class Program
    {
             static void Main()
            {
                int input = int.Parse(Console.ReadLine());

                var phrases = File.ReadAllLines("phrases.txt");
                var events = File.ReadAllLines("events.txt");
                var author = File.ReadAllLines("author.txt");
                var cities = File.ReadAllLines("cities.txt");

                Random rand = new Random();
                File.WriteAllText("output.txt", string.Empty);

                for (int i = 1; i <= input; i++)
                {
                    int phrasesIndex = rand.Next(0, phrases.Length);
                    int eventsIndex = rand.Next(0, events.Length);
                    int authorIndex = rand.Next(0, author.Length);
                    int citiesIndex = rand.Next(0, cities.Length);

                    File.AppendAllText("output.txt", $"{phrases[phrasesIndex]} {events[eventsIndex]} {author[authorIndex]} - {cities[citiesIndex]}{Environment.NewLine}");
                }
             }
    }
}