namespace EX5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount for withdraw: ");
            int withdraw = int.Parse(Console.ReadLine());
            Console.WriteLine(withdraw > 1000 ? "You can withdraw 1000$ at most!" : "");
            Console.Write("Amount in the bank account: ");
            Console.WriteLine((withdraw > 1000) ? -500 : (500 - withdraw));
            Console.Write("You are charged with ");

            Console.Write((withdraw > 1000) ? 500 * 1.7 : (withdraw > 500) ? ((withdraw - 500) * 1.7) : 0);

            Console.ReadLine();
        }
    }
}