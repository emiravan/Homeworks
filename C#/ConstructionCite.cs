using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x of Site 1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter y of Site 1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Enter x of Site 2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter y of Site 2: ");
            int y2 = int.Parse(Console.ReadLine());
            int distance1 = (x1 - (-7)) * (x1 - (-7)) + (y1 - 5) * (y1 - 5);
            int distance2 = (x2 - (-7)) * (x2 - (-7)) + (y2 - 5) * (y2 - 5);
            Console.WriteLine("Distance from Site 1 to school: " + distance1);
            Console.WriteLine("Distance from Site 2 to school: " + distance2);
            Console.Write("Construction site 1 is ");
            Console.WriteLine((distance1>120)?"allowed":"not allowed");
            Console.Write("Construction site 2 is ");
            Console.WriteLine((distance2 > 120) ? "allowed" : "not allowed");
            Console.ReadLine();


        }
    }
}
