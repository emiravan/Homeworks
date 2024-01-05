using System;

namespace LongestSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] answers =
            {
                { 'a','c','a','c','e' },
                { 'a','a','b','c','e' },
                { 'b','a','c','d','e' },
                { 'b','d','d','d','e' },
                { 'c','c','e','c','c' },
            };

            int rows = answers.GetLength(0);
            int cols = answers.GetLength(1);
            int LongestSequence = 0;
            char longestSequenceChar ='x';

            for (int i = 0; i < cols; i++)
            {
                int currentSequence = 1;
                char currentChar = answers[0, i];

                for (int j = 1; j < rows; j++)
                {
                    if (answers[j, i] == currentChar)
                    {
                        currentSequence++;

                        if (currentSequence > LongestSequence)
                        {
                            LongestSequence = currentSequence;
                            longestSequenceChar = currentChar;
                        }
                    }
                    else
                    {
                        currentSequence = 1;
                        currentChar = answers[j, i];
                    }
                }
            }
            Console.WriteLine("The longest sequence observed:{0} with {1} times.",longestSequenceChar,LongestSequence);
            Console.ReadLine();
        }
    }
}
