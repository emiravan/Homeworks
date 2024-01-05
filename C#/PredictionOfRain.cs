using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature value: ");
            int temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter wind value: ");
            int wind = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter humidity value: ");
            int humidity = int.Parse(Console.ReadLine());
            int formula = ((temperature - wind) * (temperature - wind)) - humidity;
            Console.Write("The result is " + formula);
            Console.Write((formula >= 575) ? " and there will not be rain": " and there will be rain");
            Console.ReadLine();

        }
    }
}
