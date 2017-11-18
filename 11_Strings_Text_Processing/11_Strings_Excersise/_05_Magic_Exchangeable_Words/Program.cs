using System;
using System.Linq;

namespace _05_Magic_Exchangeable_Words
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstWord = input[0];
            var secondWord = input[1];
            var result = Exchangeable(firstWord, secondWord);

            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public static Boolean Exchangeable(string firstWord, string secondWord)
        {
            bool Exchangeable = false;
            var newStr1 = firstWord.Distinct().ToArray();
            var newStr2 = secondWord.Distinct().ToArray();
            if (newStr1.Length == newStr2.Length)
            {
                Exchangeable = true;
            }
            return Exchangeable;
        }
    }
}