namespace EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, category;
            int id;
            bool isBorrowed=false;
            Console.WriteLine("WELCOME TO THE ATU LIBRARY");
            Console.Write("Please enter your book's name:");
            name = Console.ReadLine();
            Console.Write("Please enter your book's category: ");
            category = Console.ReadLine();
            string shelf = "A";
            switch (category)
            {
                case "Fiction":
                    shelf = "F";
                    break;
                case "Science":
                    shelf="S";
                    break;
                case "Poetry":
                    shelf="P";
                    break;
                case "Horror":
                    shelf="H";
                    break;
            }
            Console.WriteLine("Your book {0} is on the shelf {1}",name,shelf);
            Console.Write("Please enter your ID to complete the borrowing operation: ");
            id = int.Parse(Console.ReadLine());
            while (id > 100)
            {
                id /= 10;
                if (id == 22)
                    isBorrowed = true;
            }
            if (isBorrowed==true&&id>10000000&id<100000000)
                Console.WriteLine("You are book is borrowed");
            else
                Console.WriteLine("You are not allowed to borrow a book");


        }
    }
}