using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value a: ");
            int c = int.Parse(Console.ReadLine());
            int Delta = (b * b) - 4 * a * c;
            Console.WriteLine("Delta of the equation: ");
            Console.WriteLine(Delta);
            Console.ReadLine();



        }
    }
}
