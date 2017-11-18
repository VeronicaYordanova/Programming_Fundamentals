using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            
            int maxFromAandB = (GetMax(a, b));
            int maxOfThreeInputs = (GetMax(maxFromAandB, c));

            Console.WriteLine(maxOfThreeInputs);

        }
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
                
            }
            else
            {
                return b;
            }

        }

    }
}
