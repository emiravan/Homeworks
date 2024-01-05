using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 50);
            }

            Console.WriteLine("Newly created list is:");

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            int max, second;
            
            max = arr[0];
            second = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {              
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > second && arr[i]<max)
                {
                    second = arr[i];
                }

            }
          
            Console.WriteLine(" \n");
            Console.WriteLine("Greatest item: \n"+max);
            Console.WriteLine("Second greatest item: \n"+second);
            Console.ReadLine();
        }
    }
}
