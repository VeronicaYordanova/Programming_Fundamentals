using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Multiply_BigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            int secondInput = int.Parse(Console.ReadLine());
            firstNumber = firstNumber.PadLeft(firstNumber.Length, '0');
            StringBuilder result = new StringBuilder();

            if (firstNumber == "0" || secondInput == 0 || firstNumber == string.Empty)
            {
                Console.WriteLine(0);
                return;
            }

            var multiply = 0;
            var number = 0;
            var reminder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                multiply = (int)(int.Parse(firstNumber[i].ToString()) * secondInput + number);
                number = (int)(multiply / 10);
                reminder = (int)(multiply % 10);
                result.Append(reminder);
               

                if (i == 0 && number > 0)
                {
                    result.Append(number);
                }


            }
            Console.WriteLine(new string(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}
