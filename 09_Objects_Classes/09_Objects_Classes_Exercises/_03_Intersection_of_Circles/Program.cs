using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CircleIntersection
{
    public class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
    }
    public class Program
    {
        static void Main()
        {
            string[] firstCircleInput = Console.ReadLine().Split(' ');
            string[] secondCircleInput = Console.ReadLine().Split(' ');

            

            Circle firstCircle = new Circle();
            firstCircle.X = double.Parse(firstCircleInput[0]);
            firstCircle.Y = double.Parse(firstCircleInput[1]);
            firstCircle.Radius = double.Parse(firstCircleInput[2]);

           

            Circle secondCircle = new Circle();
            secondCircle.X = double.Parse(secondCircleInput[0]);
            secondCircle.Y = double.Parse(secondCircleInput[1]);
            secondCircle.Radius = double.Parse(secondCircleInput[2]);


            bool circlesIntersect = Intersect(firstCircle, secondCircle);
            if (circlesIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }

        static public bool Intersect(Circle firstCircle, Circle secondCircle)
        {

            double getBothX = Math.Abs(firstCircle.X - secondCircle.X);
            double getBothY = Math.Abs(firstCircle.Y - secondCircle.Y);
            double distance = Math.Sqrt(Math.Pow(getBothX, 2) + Math.Pow(getBothY, 2));
            double sumRadiuses = firstCircle.Radius + secondCircle.Radius;

            if (sumRadiuses >= distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}