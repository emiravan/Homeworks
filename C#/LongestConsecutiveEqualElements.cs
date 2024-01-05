using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];
            int counter = 1;
            for(int i=0;i<input;i++)
            {
                Console.Write("Enter the integer: ");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] == arr[i+1])
                    counter++;
            }
            
        }
    }
}
