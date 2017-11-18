using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                string email = m.ToString();
                if (!(email.StartsWith(".") || email.StartsWith("-") || email.StartsWith("_") ||
                    email.EndsWith(".") || email.EndsWith("-") || email.EndsWith("_")))
                {
                    Console.WriteLine(m.Value);
                }

            }
        }
    }
}