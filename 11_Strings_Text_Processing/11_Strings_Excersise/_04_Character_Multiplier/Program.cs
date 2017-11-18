using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var firstInput = input[0];
            var secondInput = input[1];
            var sum = 0;

            for (int i = 0; i < Math.Max(firstInput.Length, secondInput.Length); i++)
            {
                var num1 = 1;
                var num2 = 1;

                if (i < firstInput.Length)
                {
                    num1 = firstInput[i];
                }
                if (i < secondInput.Length)
                {
                    num2 = secondInput[i];
                }
                sum += num1 * num2; 
            }
            Console.WriteLine(sum);

        }
    }
}
