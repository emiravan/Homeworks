using System.Globalization;

namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userNameInput, userName, passwordInput, password = "";
            int shiftedNumber, currentDay = DateTime.Now.Day;
            int number;

            Console.WriteLine("WELCOME TO THE WHITE LOTUS HOTELS RESERVATION SYSTEM.\nPlease wait to sign up...\nPlease enter your username:");
            userName = Console.ReadLine();
            do
            {
                Console.WriteLine("Please enter a 5-digit number");
                number = int.Parse(Console.ReadLine());
                if (number <= 99999 && number > 0)
                    break;
                else
                    Console.WriteLine("Your number is invalid! Please enter a 5-digit number:");

            } while (true);

            shiftedNumber = number << 1;

            password += (char)((number % 10) + ((number / 10) % 10) + 24);
            password += currentDay.ToString();
            password += (char)(((number / 10000) % 10) + ((number / 1000) % 10) + 24);
            password += shiftedNumber.ToString();

            Console.WriteLine("Your sign up operation completed successfully.\nYour username is \"{0}\" and your password is {1}\nPlease wait to login...\nEnter your username:", userName, password);
            userNameInput = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            passwordInput = Console.ReadLine();
            if (userNameInput == userName && passwordInput == password)
            {
                Console.WriteLine("Your login is successful.\nWelcome to The White Lotus");
                Console.Write("Enter 1 to make an order:\nEnter 0 to exit:");
                int exitOrStay = int.Parse(Console.ReadLine());
                if (exitOrStay == 0)
                    Environment.Exit(0);
                if (exitOrStay == 1)
                {
                    Console.WriteLine("Enter the reservation month as an integer:");
                    do
                    {                   
                        int month = int.Parse(Console.ReadLine());
                        if (month >= 1 && month <= 12)
                            break;
                        else
                            Console.WriteLine("You must enter a valid month between 1-12");
                    } while (true);
                    Console.WriteLine("Enter the day the reservation starts:");
                    do
                    {                     
                        int day = int.Parse(Console.ReadLine());
                        if (day >= 1 && day <= 30)
                            break;
                        else
                            Console.WriteLine("You must enter a valid day between 1-30");
                    } while (true);
                    Console.WriteLine("Enter days that you wanna book:");
                    int days = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your reservation has been made successfully.");
                    DateTime startDate = DateTime.Now;
                    DateTime endDate = startDate.AddDays(days);

                    Console.WriteLine($"Your stay begins at {startDate.ToString("dd.MM.yyyy HH:mm:ss dddd")} and it ends at {endDate.ToString("dd.MM.yyyy HH:mm:ss dddd")}\nWe wish you a good experience at The White Lotus.");
                }
            }
            else
            {
                Console.WriteLine("Invalid password or username. Your operation has been cancelled...");
                Environment.Exit(0);
            }
        }
    }
}
