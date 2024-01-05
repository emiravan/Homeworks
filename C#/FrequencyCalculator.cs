namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            int[] frequency = new int[11];
            for(int i=0; i<10;i++)
            {
                numbers[i] = rnd.Next(0,11);
            }
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("{0}. number : {1}", i + 1, numbers[i]);
            }
            for(int i=0;i<10; i++)
            {
                int number = numbers[i];
                frequency[number]++;
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number : {0}, frequency : {1}", i, frequency[i]);
            }
        }
    }
}