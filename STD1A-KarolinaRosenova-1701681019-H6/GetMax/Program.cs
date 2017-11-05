using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static int a;
        static void GetMax(int first, int second)
        {
            if (first > second) a = first;
            else a = second;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(a, c);

            Console.WriteLine("Biggest number is {0}", a);
        }
    }
}

