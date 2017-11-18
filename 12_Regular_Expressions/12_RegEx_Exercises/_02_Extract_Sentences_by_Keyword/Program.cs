using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var input = Console.ReadLine();
            var pattern = $"[^.!?;]*(({word}\\W)|(\\W{word}\\W))[^.!?;]*";
      
            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m);
            }

        }
    }
}
