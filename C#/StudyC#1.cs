using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace firstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            double c = 4.5;
            double d = ++c;
            bool dorumu = d == c;
            string kelime1 = "selam";
            string kelime2 = "selam";
            bool dorumu2 = kelime1 == kelime2;
            Console.WriteLine(d + " " + c);
            Console.WriteLine(dorumu);
            Console.WriteLine(dorumu2);
            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string cumle = "volilervolidirfunilerfunidir";
            Console.WriteLine("{0} cümlesi {1} harften oluşmaktadır.", cumle, cumle.Length);

            string cumle2 = "cogimogifogi";
            string cumle3 = "cogimogifogi";
            bool isSame = string.Equals(cumle2, cumle3);
            Console.WriteLine("cumle 2 ve cumle 3 aynı mı?: " + isSame);
            int isSame2 = string.Compare(cumle2, cumle3);
            Console.WriteLine("Cumlelerin eşit olup olmama değeri: " + isSame2);

            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("Type your sentence: ");
            string sentence = Console.ReadLine();
            string[] array = sentence.Split(' ');
            Console.WriteLine("\nSentence is " + sentence);
            Console.WriteLine(" ");


            for (int i = 1; i < sentence.Length + 1; i++)
            {
                Console.WriteLine("First {0} characters of the sentence are:{1}", i, sentence.Substring(0, i));
            }

            Console.WriteLine(" ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}. word of the sentence is: {1}", i + 1, array[i]);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine("{0}. word's first {1}. characters are: {2}", i + 1, j + 1, array[i].Substring(0, j + 1));
                }
            }

            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            double myDouble = 4.8;                //converting double to int
            int myInteger = (int)myDouble;
            Console.WriteLine("int: " + myInteger);

            int myInt2 = 5;                       //converting int to double
            double myDouble2 = myInt2;
            Console.WriteLine("double: " + myDouble2);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("How many numbers do you want to sum?: ");
            int howMany = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= howMany; i++)
            {
                Console.Write("Enter {0}. number: ", i);
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum: {0}", sum);
            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("How many minutes did you work?: ");
            double minutes = int.Parse(Console.ReadLine());
            int minutesInt = (int)minutes;
            Console.WriteLine("It means you worked {0} hours and {1} minutes", minutesInt / 60, minutesInt % 60);
            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("Enter a number (1-5) and see what color are you: ");
            int input = int.Parse(Console.ReadLine());
            if (input <= 5 && input >= 1)
            {
                Console.Write("You are ");

            }

            switch (input)
            {
                case 1:
                    {
                        Console.Write("red");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("blue");
                        break;
                    }

                case 3:
                    {
                        Console.Write("yellow");
                        break;
                    }

                case 4:
                    {
                        Console.Write("orange");
                        break;
                    }

                case 5:
                    {
                        Console.Write("green");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Wrong number!");
                        break;
                    }

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter length: ");
                    int length = int.Parse(Console.ReadLine());
                    Console.Write("Enter width: ");
                    int width = int.Parse(Console.ReadLine());
                    int square = length * width;
                    int weeklyFee = 0;
                    if (square < 400)
                    {
                        weeklyFee = 25;
                    }
                    else if (square >= 400 && square <= 600)
                    {
                        weeklyFee = 35;
                    }
                    else
                    {
                        weeklyFee = 50;
                    }
                    int totalFee = weeklyFee * 20;
                    Console.Write("Square: {0}\nWeekly fee:{1}\nTotal fee: {2}", square, weeklyFee, totalFee);

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.WriteLine("Welcome to \"Number Guessing Game\"");

                    Console.Write("\nType your random number's range as (X to Y): ");
                    string numberRange = Console.ReadLine();
                    string[] arrayNumberRange = numberRange.Split("to");
                    int firstNumber = Convert.ToInt32(arrayNumberRange[0]);
                    int lastNumber = Convert.ToInt32(arrayNumberRange[1]);
                    Random rnd = new Random();
                    int random = rnd.Next(firstNumber, lastNumber);

                    while (true)
                    {
                        Console.Write("Guess the number: ");
                        int guess = int.Parse(Console.ReadLine());

                        if (guess == random && guess >= firstNumber && guess <= lastNumber)
                        {
                            Console.WriteLine("You found the correct number!");
                            Console.WriteLine("Congrulations!");
                            break;
                        }

                        else if (guess > random && guess >= firstNumber && guess <= lastNumber)
                        {
                            Console.WriteLine("Your guess was too high...");
                            Console.Write("Type \"Yes\" if you want to try again: ");
                            string yesOrNo = Console.ReadLine();
                            if (yesOrNo == "Yes")
                            {
                                continue;
                            }
                            else
                                break;
                        }

                        else if (guess < random && guess >= firstNumber && guess <= lastNumber)
                        {
                            Console.WriteLine("Your guess was too low...");
                            Console.Write("Type \"Yes\" if you want to try again: ");
                            string yesOrNo = Console.ReadLine();
                            if (yesOrNo == "Yes")
                            {
                                continue;
                            }
                            else
                                break;
                        }

                        else
                        {
                            Console.WriteLine("Number should be between {0} to {1}!", firstNumber, lastNumber);
                            continue;

                        }
                    }

                    Console.ReadLine();

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    double payRate;
                    do
                    {
                        Console.Write("Pay rate: ");
                        payRate = double.Parse(Console.ReadLine());
                    } while (payRate < 5.65 || payRate > 49.99);

                    Console.WriteLine("The valid payRate is: {0}", payRate);
                    Console.ReadLine();

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    string input;
                    do
                    {

                        Console.Write("Enter the range as X to Y: ");
                        string range = Console.ReadLine();
                        string[] rangeArray = range.Split("to");
                        int start = Convert.ToInt32((string)rangeArray[0]);
                        int end = Convert.ToInt32((string)rangeArray[1]);
                        Console.Write("Enter the increase amount: ");
                        int increaseAmount = int.Parse(Console.ReadLine());
                        int sum = ((end + start) * (end - start + increaseAmount)) / (2 * increaseAmount);
                        Console.WriteLine("Sums the integers from {0} to {1} is: {2}", start, end, sum);
                        Console.Write("Type again to contunie: ");
                        input = Console.ReadLine();

                    } while (input == "again");

                    Console.ReadLine();

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    string input;
                    do
                    {
                        Console.Write("Enter the range as X to Y: ");
                        string range = Console.ReadLine();
                        Console.Write("Enter the increase amount: ");
                        int increaseAmount = int.Parse(Console.ReadLine());
                        string[] rangeArray = range.Split("to");
                        int start = Convert.ToInt32((string)rangeArray[0]);
                        int end = Convert.ToInt32((string)rangeArray[1]);
                        int sum = 0;
                        for (int i = start; i <= end; i += increaseAmount)
                        {
                            sum += i;
                        }
                        Console.WriteLine("Sums the integers from {0} to {1} is: {2}", start, end, sum);
                        Console.ReadLine();
                        Console.Write("Type again to contunie: ");
                        input = Console.ReadLine();
                    } while (input == "again");

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("How many students are in the class: ");
                    int howMany = int.Parse(Console.ReadLine());
                    int[] grades = new int[howMany];
                    for (int i = 0; i < howMany - 1; i++)
                    {
                        Console.Write("Enter {0}. student's grade:", i + 1);
                        grades[i] = int.Parse(Console.ReadLine());
                        if (grades[i] % 5 == 3 && grades[i] > 50)
                            grades[i] += 2;
                    }
                    for (int i = 0; i < howMany - 1; i++)
                    {
                        Console.WriteLine("{0}. student's new grade is:{1}", i + 1, grades[i]);
                    }
                    Console.ReadLine();

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("How many passwords: ");
                    int howMany = int.Parse(Console.ReadLine());
                    string[] passwords = new string[howMany];
                    for (int a = 0; a < howMany; a++)
                    {
                        Console.Write("{0}. password: ", a + 1);
                        passwords[a] = Console.ReadLine();               /// YARIM PROJE
                    }
                    Random rnd = new Random();
                    char randomChar = (char)rnd.Next('a', 'z');
                    int i;
                    do
                    {
                        for (i = 0; i < howMany; i++)
                        {
                            passwords[i] += randomChar;
                        }
                    } while (passwords[i].Length != 5);
                    for (int j = 0; j < howMany; j++)
                    {
                        Console.WriteLine("{0}. password: {1}", j + 1, passwords[j]);

                    }

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    string[] students = { "ryan", "peter", "patrick", "walter" };
                    bool contains = false;
                    do
                    {
                        Console.Write("Enter student name: ");
                        string guess = Console.ReadLine();
                        for (int i = 0; i < students.Length; i++)
                        {

                            if (students[i] == guess)
                                contains = true;
                            ;
                        }
                        Console.WriteLine("{0} answer!", contains, guess,);
                    } while (contains == false);

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("How many numbers: ");
                    int howMany = int.Parse(Console.ReadLine());
                    int[] numbers = new int[howMany];
                    int sum = 0;
                    for (int i = 0; i < howMany; i++)
                    {
                        Console.Write("{0}. Number: ", i + 1);
                        int number = int.Parse(Console.ReadLine());
                        sum += number;
                        numbers[i] = number;

                    }
                    int largest = numbers[0];
                    int smallest = numbers[1];
                    for (int i = 0; i < howMany; i++)
                    {
                        if (numbers[i] > largest)
                        {
                            largest = numbers[i];
                        }
                        if (numbers[i] < smallest)
                        {
                            smallest = numbers[i];
                        }
                    }
                    Console.WriteLine("Largest number is: {0}\nSmallest number is: {1}\nSum of numbers: {2}", largest, smallest, sum);
                    Console.ReadLine();

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter weight: ");
                    double weight = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = double.Parse(Console.ReadLine());
                    double bmi = weight / (height * height);
                    string category = "Obesity";
                    if (bmi < 18.5)
                        category = "Underweight";
                    if (bmi >= 18.5 && bmi <= 24.9)
                        category = "Normalweight";
                    if (bmi >= 25 && bmi <= 29.9)
                        category = "Overweight";
                    Console.WriteLine("Your bmi: {0}\nYour category: {1}", bmi, category);
                    Console.ReadLine();

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("How many students: ");
                    int howMany = int.Parse(Console.ReadLine());
                    double total = 0;
                    double[] grades = new double[howMany];
                    for (int i = 0; i < howMany; i++)
                    {
                        Console.Write("Student {0}: ", i + 1);
                        double grade = double.Parse(Console.ReadLine());
                        total += grade;
                        grades[i] = grade;
                    }
                    Console.WriteLine("Average grade: {0}", total / howMany);

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.WriteLine("Enter number: ");
                    int number = int.Parse(Console.ReadLine());
                    bool isPalindrome = false;
                    int howManyDigit = 0;
                    for (int i = 1; i <= number; i *= 10)
                    {

                        howManyDigit++;

                    }
                    double someDouble = Math.Pow(10, howManyDigit);               /////  HATA VERİYOR
                    int someInt = (int)someDouble;
                    for (int i = 1; i <= number; i *= 10)
                    {
                        for (int j = someInt; j >= 1; j /= 10)
                        {
                            if ((number / i) % 10 == (number / j) % 10)
                            {
                                isPalindrome = true;
                            }
                            else
                                isPalindrome = false;
                        }
                    }

                    Console.WriteLine("Is number palindrome?: {1}", isPalindrome);

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    int c = 0;
                    Console.Write("a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("b: ");
                    int b = int.Parse(Console.ReadLine());
                    c = a;
                    a = b;
                    b = c;
                    Console.WriteLine("a and b are swapped\na: {0}\nb: {1}", a, b);
                    Console.ReadLine();

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("How many: ");
                    int howMany = int.Parse(Console.ReadLine());
                    int lowerCase = 0;
                    int upperCase = 0;
                    char[] chars = new char[howMany];
                    for (int i = 0; i < howMany; i++)
                    {
                        Console.Write("Enter the {0}. character: ", i + 1);
                        chars[i] = char.Parse(Console.ReadLine());
                        int charTest = chars[i];
                        if (charTest >= 65 && charTest <= 90)
                            upperCase++;
                        if (charTest >= 97 && charTest <= 122)
                            lowerCase++;
                    }
                    string more = "more uppercase";
                    if (Math.Max(lowerCase, upperCase) == lowerCase)
                    {
                        more = "more lowercase";
                    }
                    if (lowerCase == upperCase)
                    {
                        more = "same amount of lowercase and uppercase";
                    }
                    Console.WriteLine("You entered {0} lowercase letters.\nYou entered {1} uppercase letters.\nYou entered {2} letters.", lowerCase, upperCase, more);
                    Console.ReadLine();

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    double money = 500;
                    Console.Write("Enter the amount for withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    double amount = money - withdraw;
                    if (amount <= -500)
                        amount = -500;
                    double charged = amount * 1.7;
                    if (charged < 0)
                    {
                        charged *= -1;
                    }
                    if (withdraw > 1000)
                        Console.WriteLine("You can withdraw 1000$ at most!");
                    Console.WriteLine("Amount in the bank account: {0}$", amount);
                    if (withdraw > money)
                        Console.WriteLine("You are charged with: {0}$", charged);

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter x: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter y: ");
                    int y = int.Parse(Console.ReadLine());
                    int xPowerY = 1;
                    int xFactorial = 1;
                    for (int i = 1; i <= x; i++)
                    {
                        xFactorial *= i;
                    }
                    for (int i = 1; i <= y; i++)
                    {
                        xPowerY *= x;
                    }
                    double result = (double)xPowerY / xFactorial;
                    Console.WriteLine("x!: {0}\nx^y: {1}\nResult: {2}", xFactorial, xPowerY, result);

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());
                    int sum = 0;
                    string isPerfect = " not ";
                    for (int i = 1; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine("{0} is divisible by {1}", number, i);
                            sum += i;
                        }
                    }
                    if (number == sum)
                    {
                        isPerfect = " ";
                    }
                    Console.WriteLine("The sum of divisors: {0}\n{1} is{2}a perfect number", sum, number, isPerfect);

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Random rnd = new Random();
                    int number = rnd.Next(10);
                    int guess;
                    int right = 5;
                    do
                    {
                        Console.WriteLine("Enter a number");
                        guess = int.Parse(Console.ReadLine());
                        right--;
                        if (guess != number)
                        {
                            Console.WriteLine("Couldn't find it yet :(\nYour remaining guess : {0}", right);
                        }
                    } while (guess != number && right != 0);
                    if (right == 0)
                    {
                        Console.WriteLine("\nYou have no right!!!\nCorrect number is : {0}", number);
                    }
                    if (guess == number)
                        Console.WriteLine("Congrulations you found the number :)");

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    int pinCode = 4545;
                    int guess;
                    int right = 0;
                    do
                    {
                        right++;
                        Console.Write("Enter pin code ({0}.right) : ", right);
                        guess = int.Parse(Console.ReadLine());
                        if (guess != pinCode)
                            Console.WriteLine("Pin code is invalid");
                        else
                            Console.WriteLine("Pin code is valid");

                    } while (guess != pinCode && right != 3);
                    if (guess != pinCode)
                    {
                        Console.WriteLine("You have no rights!!!");
                    }

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    int i = 1, j = 1;
                    while (i < 10)
                    {
                        for (j = 1; j < 10; j++)
                        {
                            Console.WriteLine("{0}x{1} = {2}", i, j, i * j);
                        }
                        Console.WriteLine("-----------------------------");
                        i++;
                    }

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter the number: ");
                    int number = int.Parse(Console.ReadLine());
                    string message = "not divisible by both 5 or 7.";
                    if (number < 0)
                        Console.WriteLine("Error! Number {0} is smaller than 0.", number);
                    else if (number > 500)
                        Console.WriteLine("Error! Number {0} is bigger than 500.", number);
                    else
                    {
                        if (number % 5 == 0 && number % 7 == 0)
                            message = "divisible by both 5 and 7.";
                        if (number % 5 == 0 && number % 7 != 0)
                            message = "divisible by 5.";
                        if (number % 5 != 0 && number % 7 == 0)
                            message = "divisible by 7";
                        Console.WriteLine("Number {0} is {1}", number, message);
                    }

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    int point = 0;
                    string message = " ";

                    Console.WriteLine("Select your age intevral\n1) 18-40\n2) 40-65\n3) 65+");
                    Console.Write("Your choice: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Have you experienced COV19 Symptoms?\n1) Yes\n2) No");
                    Console.Write("Your choice: ");
                    int symptoms = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is your COV19 test result?\n1) Positive\n2) Negative");
                    Console.Write("Your choice: ");
                    int result = int.Parse(Console.ReadLine());
                    Console.WriteLine("Have you been infected with COV19 before?\n1) Yes\n2) No");
                    Console.Write("Your choice: ");
                    int history = int.Parse(Console.ReadLine());

                    switch (age)
                    {
                        case 1:
                            point += 5;
                            break;
                        case 2:
                            point += 15;
                            break;
                        case 3:
                            point += 25;
                            break;
                    }

                    switch (symptoms)
                    {
                        case 1:
                            point += 25;
                            break;
                        case 2:
                            point += 0;
                            break;
                    }

                    switch (result)
                    {
                        case 1:
                            point += 25;
                            break;
                        case 2:
                            point += 0;
                            break;
                    }

                    switch (history)
                    {
                        case 1:
                            point += 0;
                            break;
                        case 2:
                            point += 25;
                            break;
                    }

                    if (point >= 0 && point < 25)
                        message = "Patient should rest at home.";
                    if (point >= 25 && point < 50)
                        message = "Patient should rest at home with medicine.";
                    if (point >= 50 && point < 75)
                        message = "Patient should be controlled under the doctor.";
                    if (point >= 75 && point <= 100)
                        message = "Patient should be intubated immediately.";

                    Console.WriteLine("Total score of the assessment is: {0}\n{1}", point, message);

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter the first side: ");
                    int firstSide = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second side: ");
                    int secondSide = int.Parse(Console.ReadLine());
                    Console.Write("Enter the third side: ");
                    int thirdSide = int.Parse(Console.ReadLine());
                    Console.Write("Enter the first angle: ");
                    int firstAngle = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second angle: ");
                    int secondAngle = int.Parse(Console.ReadLine());
                    Console.Write("Enter the third angle: ");
                    int thirdAngle = int.Parse(Console.ReadLine());

                    string isSide = " not ";
                    string isAngle = " not ";
                    string type = "Scalene";

                    if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)
                        isSide = " ";
                    if (firstAngle + secondAngle + thirdAngle == 180 && firstAngle > 0 && secondAngle > 00 && thirdAngle > 0)
                        isAngle = " ";

                    if (firstSide == secondSide && secondSide == thirdSide)
                        type = "Equilateral";
                    if ((firstSide == secondSide && secondSide != thirdSide) || (firstSide == thirdSide && thirdSide != secondSide) || (secondSide == thirdSide && thirdSide != firstSide))
                        type = "İsosceles";
                    Console.WriteLine("Sides are{0}meeting the conditions.\nAngles are{1}meeting the conditions.", isSide, isAngle);
                    if (isAngle == " " && isSide == " ")
                    {
                        Console.WriteLine("{0} triangle", type);
                    }

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter total units consumed: ");
                    int unit = int.Parse(Console.ReadLine());
                    int bill;
                    if (unit <= 50)
                        bill = unit / 2;
                    else if (unit > 50 && unit < 150)
                        bill = (50 / 2) + (unit - 50) * (3 / 4);
                    else if (unit >= 150 && unit < 250)
                        bill = (50 / 2) + (100) * (3 / 4) + (unit - 150) * (12 / 10);
                    else
                        bill = (50 / 2) + (100) * (3 / 4) + (100) * (12 / 10) + (unit - 250) * (3 / 2);
                    int netBill = bill + (bill * 20 / 100);
                    Console.WriteLine("Net electricity bill is {0}$", netBill);

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.Write("Enter your password: ");
                    int password = int.Parse(Console.ReadLine());
                    int price;
                    if (password >= 1000 && password <= 999999)
                    {
                        Console.Write("Enter a brand name or computer ID: ");
                        string input = Console.ReadLine();
                        if (input == "Dell" || input == "234")
                        {
                            Console.Write("Are you a student? (Y/N) : ");
                            char isStudent = Convert.ToChar(Console.ReadLine());
                            if (isStudent == 'Y')
                                price = 2500 * (8 / 10);
                            else
                                price = 2500;
                            Console.WriteLine("Total price is {0}$", price);
                        }
                        else if (input == "Asus" || input == "536")
                        {
                            Console.Write("Are you a student? (Y/N) : ");
                            char isStudent = Convert.ToChar(Console.ReadLine());
                            if (isStudent == 'Y')
                                price = (1500 * (8 / 10));
                            else
                                price = 1500;
                            Console.WriteLine("Total price is {0}$", price);
                        }
                        else if (input == "Monster" || input == "862")
                        {
                            Console.Write("Are you a student? (Y/N) : ");
                            char isStudent = Convert.ToChar(Console.ReadLine());
                            if (isStudent == 'Y')
                                price = 1000 * (8 / 10);
                            else
                                price = 1000;
                            Console.WriteLine("Total price is {0}$", price);

                        }
                        else if (input == "HP" || input == "601")
                        {
                            Console.Write("Are you a student? (Y/N) : ");
                            char isStudent = Convert.ToChar(Console.ReadLine());
                            if (isStudent == 'Y')
                                price = 1750 * (8 / 10);
                            else
                                price = 1750;
                            Console.WriteLine("Total price is {0}$", price);
                        }
                        else
                            Console.WriteLine("There is no matching brand name or ID according to your input.");
                    }
                    else
                        Console.WriteLine("Password is incorrect!");

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    Console.WriteLine("Enter your access type: ");
                    string accessType = Console.ReadLine();
                    Console.WriteLine("Enter your file ID: ");
                    string fileID = Console.ReadLine();
                    bool accessTypeValid = false;
                    bool fileIDValid = false;
                    if (accessType == "0001" || accessType == "1120" || accessType == "2202")
                        accessTypeValid = true;
                    if (fileID == "0001" || fileID == "1100" || fileID == "3521")
                        fileIDValid = true;
                    if (fileIDValid == true && accessTypeValid == true)
                        Console.WriteLine("Access is allowed");
                    else
                        Console.WriteLine("Access is invalid");

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    double fee = 50;
                    int floor, room, month;
                    Console.Write("Enter the number of floors : ");
                    floor = int.Parse(Console.ReadLine());
                    Console.Write("Enter the number of the room : ");
                    room = int.Parse(Console.ReadLine());


                    if (room < floor / 4)
                    {
                        fee = 50;
                    }
                    else if (room < floor / 2)
                    {
                        fee += fee * (10 / 100);
                    }
                    else
                    {
                        fee += 15;
                    }

                    Console.Write("Enter month number :");
                    month = int.Parse(Console.ReadLine());
                    if (month % 2 == 1)
                    {
                        fee -= fee * (5 / 100);
                    }

                    Console.WriteLine("Amount to be paid : {0:F2}", fee);
                    Console.ReadLine();
/
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int velocity1, velocity2,velocity12,velocity22, area, acc1 = 1, acc2 = 1,takenWay1,takenWay2;
                    Console.Write("Enter the initial velocity of the car 1 :");
                    velocity1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the initial velocity of the car 2 :");
                    velocity2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the race area : (between 1 and 3) :");
                    area = int.Parse(Console.ReadLine());

                    switch (area)
                    {
                        case 1:
                            acc1 = 15;
                            acc2 = 10;
                            break;
                        case 2:
                            acc1 = 10;
                            acc2 = 12;
                            break;
                        case 3:
                            acc1 = 17;
                            acc2 = 20;
                            break;
                    }
                    takenWay1 = velocity1 + acc1 * 10;
                    takenWay2 = velocity1 + acc2 * 10;
                    velocity12 = velocity1 + acc1 * 10;
                    velocity22 = velocity2 + acc2 * 10;
                    Console.WriteLine("Velocity of the first car after 10 seconds : {0}\nVelocity of the second car after 10 seconds : {1}", velocity12, velocity22);
                    if (takenWay1 > takenWay2)
                    {
                        Console.WriteLine("First car won the race");
                    }
                    else
                        Console.WriteLine("Second car won the race");

                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////









            }
        }

    }

