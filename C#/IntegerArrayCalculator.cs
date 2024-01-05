using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            Menu(arr);
        }

        static void Menu(int[] arr)
        {
            Console.Write("Enter 1 to perform Summation\nEnter 2 to perform multiplication\nEnter 3 to see the Mean Value of the array: ");
            int input = int.Parse(Console.ReadLine());
            if(input ==1)
            {
                int summation = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    summation += arr[i];
                }
                Console.WriteLine("The sum of the elements in array: "+summation);
            }
            else if(input ==2)
            {
                int multiplication = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    multiplication *= arr[i];
                }
                Console.WriteLine("The multiplication of the elements in array: " + multiplication);
            }
            else if(input ==3)
            {
                int summation = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    summation += arr[i];
                }
                double meanValue = (double)summation / arr.Length;
                Console.WriteLine("The mean value of the elements in array: " + meanValue);
            }
            Console.ReadLine();
        }
    }
}
