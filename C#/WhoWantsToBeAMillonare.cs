namespace Q4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Which one is the highest mountain in Turkey?");
            Console.WriteLine("A) KAZ MOUNTAINS B) AMANOSES C) AĞRI MOUNTAIN D) NEMRUT MOUNTAIN");
            string answer1 = Console.ReadLine();

            if (answer1 == "C")
            {
                Console.WriteLine("You answered right");

                Console.WriteLine("Who is the first known woman computer programmer?");
                Console.WriteLine("A) MARIE CURIE B) ADA LOVELACE C) PARISA TABRIZ D) CELINE DION");
                string answer2 = Console.ReadLine();

                if (answer2 == "B")
                {
                    Console.WriteLine("You answered right");

                    Console.WriteLine("When was the latest championship that Fenerbahçe won?");
                    Console.WriteLine("A) 2012-2013 B) 2013-2014 C) 2014-2015 D) 2015-2016");
                    string answer3 = Console.ReadLine();

                    if (answer3 == "B")
                    {
                        Console.WriteLine("You won the 1M!");
                    }
                    else
                    {
                        Console.WriteLine("You lost the game :(");
                    }
                }
                else
                {
                    Console.WriteLine("You lost the game :(");
                }
            }
            else
            {
                Console.WriteLine("You lost the game :(");
            }
        }
    }
}