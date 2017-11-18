using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_of_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            string secondNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            StringBuilder result = new StringBuilder();

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else if (firstNumber.Length < secondNumber.Length)
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }
            var sum = 0;
            var number = 0;
            var reminder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                sum = firstNumber[i] - 48 + secondNumber[i] - 48 + reminder;
                number = sum % 10;
                result.Append(number);
                reminder = sum / 10;

                if (i == 0 && reminder > 0)
                {
                    result.Append(reminder);
                }
            }
            //Console.WriteLine(secondNumber);
            //Console.WriteLine(firstNumber);
            Console.WriteLine(new string(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));

        }
    }
}
