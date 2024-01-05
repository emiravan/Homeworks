using System.Diagnostics.Metrics;
using System;
using System.Globalization;

namespace secondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string status, rating;
            bool yesNo;

            Console.WriteLine("Enter your age :");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your student status as yes or no :");
            status = Console.ReadLine();
            Console.WriteLine("Enter your credit rating as excellent or fair :");
            rating = Console.ReadLine();

            if (age <= 30)
            {
                if (status == "yes")
                {
                    yesNo = true;
                }
                else if (status == "no")
                {
                    yesNo = false;
                }
            }
            else if (age >= 31 && age <= 40)
            {
                yesNo = true;
            }
            else
            {
                if (rating == "fair")
                {
                    yesNo = true;
                }
                else if (rating == "excellent")
                {
                    yesNo = false;
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int gradeHighest = -1;
            int gradeLowest = 101;
            string nameHighest = "a";
            string nameLowest = "b";

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Enter the student's name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the student's grade: ");
                int grade = int.Parse(Console.ReadLine());
                if (grade > gradeHighest)
                {
                    gradeHighest = grade;
                    nameHighest = name;
                }
                if (grade < gradeLowest)
                {
                    gradeLowest = grade;
                    nameLowest = name;
                }
            }
            Console.WriteLine("Highest score ({0}) belongs to {1}\nLowest score ({2}) belongs to {3}", gradeHighest, nameHighest, gradeLowest, nameLowest);
            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int number = n;

            int sum = 0;

            do
            {
                int digit = n % 10;
                int fac = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fac *= i;
                }
                sum += fac;
                n /= 10;
            } while (n > 0);

            string strong = " not ";
            if (number == sum)
            {
                strong = " ";
            }
            Console.WriteLine("{0} is{1}strong number", number, strong);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int number = n;
            int sum = 0;
            int multiply = 1;
            do
            {
                int digitOdd = n % 10;
                multiply *= digitOdd;
                n /= 10;
                int digitEven = n % 10;
                sum += digitEven;
                n /= 10;

            } while (n > 0);
            Console.WriteLine("Product of odd numbers is: {0}\nSum of even numbers is: {1}", multiply, sum);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            int bolen1 = 0;
            int bolen2 = 0;
            for (int i = 1; i < first; i++)
            {
                if (first % i == 0)
                {
                    i = bolen1;
                }

            }

            for (int i = 1; i < second; i++)
            {
                if (first % i == 0)
                {
                    i = bolen2;
                }

            }
            Console.WriteLine(bolen1);
            Console.WriteLine(bolen2);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Random rnd = new Random();
            int a = 2, b = 4, c = -6;
            double delta = (b * b) - (4 * a * c);
            double firstRoot = (-b + Math.Sqrt(delta)) / (2 * a);
            double secondRoot = (-b - Math.Sqrt(delta)) / (2 * a);
            int iteration = 0;
            double guessFirst;
            double guessSecond;
            do
            {
                iteration++;
                guessFirst = rnd.Next(0, 10);
                guessSecond = rnd.Next(-10, 0);
                Console.WriteLine("{0}. iteration - Root1: {1} Root2: {2}", iteration, guessFirst, guessSecond);
            } while (guessFirst != firstRoot || guessSecond != secondRoot);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Random rnd = new Random();
            Console.Write("Enter number of sentences: ");
            int number = int.Parse(Console.ReadLine());
            int times = 0;
            int length;
            int rndValue;
            string str = "";
            char letter;
            do
            {

                times++;
                length = rnd.Next(3, 10);
                for (int i = 0; i < length; i++)
                {
                    rndValue = rnd.Next(0, 26);
                    letter = Convert.ToChar(rndValue + 65);
                    str += letter;
                }

                Console.WriteLine(str);
            } while (times < number);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("Enter the length from the center to a vertex : ");
            double r = double.Parse(Console.ReadLine());  // r=length
            double s = 2 * r * Math.Sin(Math.PI / 5);
            double area = (5 * Math.Pow(s, 2)) / (4 * Math.Tan(Math.PI / 5));
            Console.WriteLine("s : {0}\nArea : {1}", Math.Round(s, 2), Math.Round(area, 2));

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int size, numberOfFiles, fileType, compressionType, totalMemoryUsage = 0;
            Console.WriteLine("How many files do you want to compress:");
            howMany = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfFiles; i++)
            {
                Console.WriteLine("Enter the size of the {0}. file", i);
                size = int.Parse(Console.ReadLine());
                Console.WriteLine("What file type do you want to convert?\n1-PowerPoint\n2-PDF");
                fileType = int.Parse(Console.ReadLine());
                switch (fileType)
                {
                    case 1:
                        size += 150;
                        break;
                    case 2:
                        size /= 2;
                        break;
                }
                Console.WriteLine("What compression type do you want to use?\n1-PowerPoint\n2-PDF");
                compressionType = int.Parse(Console.ReadLine());
                switch (compressionType)
                {
                    case 1:
                        size /= 3;
                        break;
                    case 2:
                        size /= 4;
                        break;
                }
                totalMemoryUsage += size;
            }
            Console.WriteLine("Total memory usage : {0}", totalMemoryUsage);
            Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int currentValue, player, computer, term = 0;
            Random rnd = new Random();
            currentValue = rnd.Next(10, 25);
            while (currentValue > 1)
            {
                term++;
                Console.Write("Current value : {0}\nPlayer A is playing (1 or 2) : ", currentValue);
                player = int.Parse(Console.ReadLine());
                currentValue -= player;
                computer = rnd.Next(1, 2);
                Console.WriteLine("Current value : {0}\nPlayer B played randomly (1 or 2) : {1}", currentValue, computer);
                currentValue -= computer;
                if (currentValue <= 1)
                {
                    if (term % 2 == 0)
                    {
                        Console.WriteLine("Game finished!\nPlayer A won the game!");
                    }
                    else
                        Console.WriteLine("Game finished!\nPlayer B won the game!");
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int length;
            Console.Write("Enter the length of the array: ");
            length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter the integer: ");
                myArray[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < length; i++)
            {
                if (myArray[i] == myArray[i + 1] && myArray[i] == myArray[i + 2])
                {
                    Console.WriteLine("Maximal sequence of numbers is: {{0}, {1}, {2}", myArray[i], myArray[i + 1], myArray[i + 2]);
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string first, second;

            Console.Write("Enter the first string: ");
            first = Console.ReadLine();
            Console.Write("Enter the second string: ");
            second = Console.ReadLine();

            char[] firstChar = new char[first.Length];
            char[] secondChar = new char[second.Length];

            for (int i = 0; i < first.Length; i++)
            {
                firstChar[i] = first[i];
                secondChar[i] = second[i];
            }
            if (firstChar.Length < secondChar.Length)
            {
                Console.WriteLine("First string comes before second string.");
            }
            else if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (firstChar[i] > secondChar[i])
                    {
                        Console.WriteLine("Second string comes before first string.");
                        break;
                    }

                    else if (secondChar[i] > firstChar[i])
                    {
                        Console.WriteLine("First string comes before Second string.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Two arrays are equal");
                        break;
                    }


                }
            }
            else
            {
                Console.WriteLine("Second string comes before first string.");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int firstSize, secondSize;
            bool isEqual = false, isContain = false;

            Console.Write("Enter the size of the first array : ");
            firstSize = int.Parse(Console.ReadLine());
            int[] firstArray = new int[firstSize];

            for (int i = 0; i < firstSize; i++)
            {
                Console.Write("Enter {0}. value of the first array : ", i + 1);
                firstArray[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("Enter the size of the second array : ");
            secondSize = int.Parse(Console.ReadLine());
            int[] secondArray = new int[secondSize];

            for (int i = 0; i < secondSize; i++)
            {
                Console.Write("Enter {0}. value of the first array : ", i + 1);
                secondArray[i] = int.Parse(Console.ReadLine());

            }
            if (firstArray.Length == secondArray.Length)
            {
                isContain = false;
                for (int i = 0; i < firstSize; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        isContain = true;
                        break;
                    }
                }
                if (isContain == true)
                {
                    Console.WriteLine("They are same :)");
                }
                else
                    Console.WriteLine("They are not same :(");
            }
            else
                Console.WriteLine("They are not same :(");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Random rnd = new Random();
            int[] numbers = new int[10];
            int[] frequency = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 10);
                Console.WriteLine("{0}. number : {1}", i + 1, numbers[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                frequency[numbers[i]] += 1;
            }
            for (int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine("Number : {0}, frequency : {1}", i, frequency[i]);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////       

            Console.Write("Full string : ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(".");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("{0}. split : {1}", i + 1, words[i]);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   

            Random rnd = new Random();
            int[] myArray = new int[15];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(-100, 100);
            }
            Console.WriteLine("Randomly created array with length 15 is:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
            int temp = 0;
            Console.WriteLine("\n\nSorted array with length 15 is:");
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        temp = myArray[j + 1];
                        myArray[j + 1] = myArray[j];
                        myArray[j] = temp;
                    }
                }

            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   

            int N, total, biggest = 0;
            int[] values;

            Console.Write("Enter the length of the array:");
            N = int.Parse(Console.ReadLine());
            values = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter the value: ");
                values[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                total = 0;
                for (int j = i; j < N; j++)
                {
                    total += values[j];
                    if (total > biggest)
                        biggest = total;
                }
            }
            Console.WriteLine("Maximum sum: {0}", biggest);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

            Random rnd = new Random();
            int[] myArray;
            int greatest = 0, secondGreatest = 0, greatestIndex = 0;
            myArray = new int[15];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(0, 50);
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] >= greatest)
                {
                    greatest = myArray[i];
                    greatestIndex = i;
                }

            }
            myArray[greatestIndex] = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > secondGreatest)
                {
                    secondGreatest = myArray[i];
                }
            }
            Console.WriteLine("\nGreatest item: {0}\nSecond greatest item: {1}", greatest, secondGreatest);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

            int x, sum = 0;
            Console.Write("Length of square: ");
            x = int.Parse(Console.ReadLine());
            int[,] myArray = new int[x, x];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write("Array[{0},{1}]: ", i, j);
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();

            }

            int upperSum = 0;

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                        upperSum += myArray[i, j];
                    }
                }
            }
            Console.WriteLine("\nUpper sum: {0}", upperSum);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        }
    }