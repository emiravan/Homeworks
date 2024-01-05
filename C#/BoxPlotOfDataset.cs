using System.Data;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = new int[15];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 101);
            }

            Console.WriteLine("Randomly created array with length 15 is:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted array with length 15 is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int q1Index = arr.Length / 4;
            int q3Index = 3 * arr.Length / 4;
            int q1 = arr[q1Index];
            int q3 = arr[q3Index];
            int iqr = q3 - q1;
            int minimum = arr[0];
            int maximum = arr[arr.Length - 1];
            double median;

            if (arr.Length % 2 == 0)
            {
                median = (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2.0;
            }
            else
            {
                median = arr[arr.Length / 2];
            }

            Console.WriteLine("\nQ1 of the array is: {0}",q1);
            Console.WriteLine("Q3 of the array is: {0}",q3);
            Console.WriteLine("IQR of the array is: {0}",iqr);
            Console.WriteLine("Minimum of the array is: {0}",minimum);
            Console.WriteLine("Maximum of the array is: {0}",maximum);
            Console.WriteLine("Median of the array is: {0}",median);
        }
    }
}