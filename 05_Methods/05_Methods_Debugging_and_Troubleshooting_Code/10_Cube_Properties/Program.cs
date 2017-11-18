using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfTheCube = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            if (type == "face")
            {
                Console.WriteLine("{0:F2}", FaceDiagonals(sideOfTheCube));
            }
            else if (type == "space")
            {
                Console.WriteLine("{0:F2}", SpaceDiagonals(sideOfTheCube));
            }
            else if (type == "volume")
            {
                Console.WriteLine("{0:F2}", Volume(sideOfTheCube));
            }
            else if (type == "area")
            {
                Console.WriteLine("{0:F2}", SurfaceArea(sideOfTheCube));
            }
        }

        static double FaceDiagonals(double sideOfTheCube)
        {           
             double result = Math.Sqrt(2 * (Math.Pow(sideOfTheCube, 2)));
             return result;
        }

        static double SpaceDiagonals(double sideOfTheCube)
        {
            double result = Math.Sqrt(3 * (Math.Pow(sideOfTheCube,2)));
            return result;
        }

        static double Volume(double sideOfTheCube)
        {
            double result = (Math.Pow(sideOfTheCube, 3));
            return result;
        }


        static double SurfaceArea(double sideOfTheCube)
        {
            double result =  6*(Math.Pow(sideOfTheCube, 2));
            return result;
        }

    }
}