using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st character: ");
            char first = char.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd character: ");
            char second = char.Parse(Console.ReadLine());
            Console.Write("Enter the 3rd character: ");
            char third = char.Parse(Console.ReadLine());
            Console.Write("Enter the 4th character: ");
            char fourth = char.Parse(Console.ReadLine());
            Console.Write("Enter the 5th character: ");
            char fifth = char.Parse(Console.ReadLine());

            int number1 = 0, number2 = 0, number3 = 0, number4 = 0, number5 = 0;

            _ = (first >= 65 && first <=90) ? number1 = 1 : 0;
           _ = (second >= 65 && second <= 90) ? number2 = 1 : 0;
            _ = (third >= 65 && third <= 90) ? number3 = 1 : 0;
            _ = (fourth >= 65 && fourth <= 90) ? number4 = 1 : 0;
            _ = (fifth >= 65 && fifth <= 90) ? number5 = 1 : 0;

            Console.WriteLine("you entered "+(number1 + number2 + number3 + number4 + number5 ) + " uppercase characters");
            Console.WriteLine("you entered "+(5-(number1 + number2 + number3 +number4 + number5))+" lowercase characters");
            Console.Write("you entered more ");
            Console.WriteLine(((number1 + number2 + number3 + number4 + number5) >= 3) ? "uppercase letters" : "lowercase letters");

            Console.ReadLine();
        }
    }
}
