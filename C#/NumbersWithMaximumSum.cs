using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the length of the array:");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter the value: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;                 
            int min = 0;
            int max2 = 0;
            int min2 = 0;
            int sumMax = 0;
            int sumMin = 0;

            int maxSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sumMax += arr[i];
                if (sumMax > max)
                {
                    max2 = i;
                    max = sumMax;
                }
            }
       
            for (int i = max2; i != 0; i--)
            {
                sumMin += arr[i];
                if (sumMin > min)
                {
                    min2 = i;
                    min = sumMin;
                }
            }

            for (int i = min2; i <= max2; i++)
            {
                maxSum+=arr[i];
            }

            Console.WriteLine("Maximum sum: {0}",maxSum);

            Console.ReadLine();
        }
    }
}
