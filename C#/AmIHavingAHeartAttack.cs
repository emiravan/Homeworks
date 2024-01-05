using System.Diagnostics.CodeAnalysis;

namespace EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            string fever, sneez, back, chest, nausea;

            Console.WriteLine("Do you have a fever?");
            fever = Console.ReadLine();
            if (fever == "yes")
                score += 1;

            Console.WriteLine("Are you sneezing?");
            sneez = Console.ReadLine();
            if (sneez == "yes")
                score += 1;

            Console.WriteLine("Does your back or arm hurt?");
            back = Console.ReadLine();
            if (back == "yes")
                score += 3;

            Console.WriteLine("Does your chest hurt?");
            chest = Console.ReadLine();
            if (chest == "yes")
                score += 5;

            Console.WriteLine("Do you have nausea?");
            nausea = Console.ReadLine();
            if (nausea == "yes")
                score += 1;

            if (score >=6)
                Console.WriteLine("You should go to the nearest hospital. You might have a heart attack");
            else
                Console.WriteLine("You are just having a flu, have a cup of hot tea.");


        }
    }
}