using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value b: ");
            int b=int.Parse(Console.ReadLine());
            int swap = a;
            a = b;
            b = swap;
            Console.Write("Value of a is: " + a + " and value of b is: " + b);
            Console.ReadLine();
        }
    }
}
