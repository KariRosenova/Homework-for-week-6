using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static double Triangle(double a, double ha)
        {
            return a * ha;
        }

        static double Square(double s)
        {
            return s * s;
        }

        static double Degrees(double d)
        {
           return  (Math.PI / 180) * d;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle, square or radians):");
            var choose = Console.ReadLine();

            if (choose == "triangle")
            {
                double a, ha;
                Console.WriteLine("Enter side: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                ha = double.Parse(Console.ReadLine());
                Console.WriteLine("The area of the triangle is = {0:F2}", (Triangle(a, ha)));               
            }

            else if (choose == "square")
            {
                double s;
                Console.WriteLine("Enter side: ");
                s = double.Parse(Console.ReadLine());
                Console.WriteLine("The area of the square is = {0:F2}", (Square(s)));
            }

            else if (choose == "radians")
            {
                double d;
                Console.WriteLine("Enter the degrees you want to transform in radians: ");
                d = double.Parse(Console.ReadLine());
                Console.WriteLine("Your degrees in radians are = {0:F2}", (Degrees(d)));
            }

            else
            {
                Console.WriteLine("Choose from shown options!");
            }
        }
    }
}
