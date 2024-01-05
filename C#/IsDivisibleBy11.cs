using System.Runtime.CompilerServices;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,oddSum=0,evenSum=0;
            Console.Write("Please enter a 5-digit number: ");
            number= int.Parse(Console.ReadLine());
            for(int i=0;i<5;i++)
            {
                int digit = number % 10;
                number/= 10;
                
                if(i%2==0)
                    oddSum+=digit;
                else
                    evenSum+=digit;
            }
            if(oddSum==evenSum)
                Console.WriteLine("This number is divisible by 11");
            else
                Console.WriteLine("This number is not divisible by 11");
        }
    }
}