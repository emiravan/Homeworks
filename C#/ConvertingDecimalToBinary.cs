namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,i;
            Console.WriteLine("Enter the decimal number:");
            number = int.Parse(Console.ReadLine());
            int[] numbers = new int[10];
            for (i = 0;number>0; i++)
            {
                numbers[i] = number % 2;
                number /= 2;
            }

            Console.Write("Binary: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }
        }
    }
}