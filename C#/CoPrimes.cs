namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,smaller;
            Console.Write("Enter the first number: ");
            num1=int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2=int.Parse(Console.ReadLine());
            if (num2 < num1)
                smaller = num1;
            else smaller = num2;
            for (int i = 2; i <= smaller; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    Console.WriteLine("These numbers are not coprimes");
                    return;
                }
            }
            Console.WriteLine("These numbers are coprimes");
            Console.ReadLine();

        }
    }
}