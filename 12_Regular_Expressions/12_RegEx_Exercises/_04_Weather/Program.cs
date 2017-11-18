using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Weather
{
    class Program
    {
        static void Main()
        {
            string pattern = @"([A-Z]{2})(\d{2}.\d{1,2})([A-Za-z]+)\|";
            string input = Console.ReadLine();
            
            Dictionary<string, double> cityWithTemperature = new Dictionary<string, double>();
            Dictionary<string, string> cityWithWeather = new Dictionary<string, string>();

            while (input != "end")
            {
                
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    string city = m.Groups[1].Value;
                    double weatherValue = double.Parse(m.Groups[2].Value);
                    string typeOfWeather = m.Groups[3].Value;

                    cityWithTemperature[city] = weatherValue;
                    cityWithWeather[city] = typeOfWeather;
                }
                input = Console.ReadLine();
            }

            Dictionary<string, double> sortedCitiesByTemp =
                cityWithTemperature
                .OrderBy(c => c.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedCitiesByTemp)
            {
                Console.WriteLine($"{item.Key} => {item.Value} => {cityWithWeather[item.Key]}");
            }

       }
    }
}
