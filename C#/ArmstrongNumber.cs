using System.Globalization;
using System.Runtime.CompilerServices;

namespace EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int check,number, remainder,sum=0;
            Console.Write("Please enter a 3-digit number: ");
            number = int.Parse(Console.ReadLine());
            check = number;
            while(number>0)
            {
                remainder = number % 10;
                sum += remainder * remainder * remainder;
                number /= 10;
            }
            if (sum==check)
            {
                Console.WriteLine("This number is an Armstrong Number");
            }
            else
            {
                Console.WriteLine("This number is not an Armstrong Number");
            }
        }
    }
}