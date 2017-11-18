using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
          

            if (type == "triangle")
            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double heightOfTriangle = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", AreaOfTriangle(sideOfTriangle, heightOfTriangle));
            }
            else if (type == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", AreaOfSquare(sideOfSquare));
            }
            else if (type == "rectangle")
            {
                double widthOfRectangle = double.Parse(Console.ReadLine());
                double heightOfRectangle = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", AreaOfRectangle(widthOfRectangle, heightOfRectangle));
            }
            else if (type == "circle")
            {
                double radiusOfCircle = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", AreaOfCircle(radiusOfCircle));
            }
        }

        static double AreaOfTriangle(double sideOfTriangle, double heightOfTriangle)
        {
            return (sideOfTriangle * heightOfTriangle) / 2;
        }
        static double AreaOfSquare(double sideOfSquare)
        {
            return Math.Pow(sideOfSquare,2);
        }
        static double AreaOfRectangle(double widthOfRectangle, double heightOfRectangle)
        {
            return widthOfRectangle * heightOfRectangle;
        }
        static double AreaOfCircle(double radiusOfCircle)
        {
            return Math.PI * Math.Pow(radiusOfCircle, 2);
        }
    }
}
