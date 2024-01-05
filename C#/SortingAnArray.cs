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
            //step1:creating array and filling with random integers

            int[] arr = new int[15];
            Random random = new Random();      

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }

            //step2:writing to the console

            Console.WriteLine("Randomly created array with length 15 is:");
            foreach (var sort1 in arr)
            {
                Console.Write(sort1 + " ");
            }


            //step3:sorting integers by using bubble sort method

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp;

                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            //step4:writing to the console

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Sorted array with 15 length 15 is:");
            foreach (var sort2 in arr)
            {
                Console.Write(sort2 + " ");
            }

            Console.ReadLine();


        }
    }
}
