namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers to create an array:");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine("The sorted array is");
            for (int i=0;i<arr.Length ;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}