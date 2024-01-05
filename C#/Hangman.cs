using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        string[] words = new string[9] { "experience", "encapsulation", "authentication", "human", "person", "terrified", "bowl", "christmas", "squad" };
        string wordRandom = words[random.Next(0, 8)];
        char[] word = new char[wordRandom.Length];
        char[] hangman = new char[word.Length];
        for (int j = 0; j < word.Length; j++)
        {
            word[j] = wordRandom[j];
            hangman[j] = '_';
        }
        while (!AreArraysEqual(hangman,word))
        {
            Console.WriteLine(hangman);
            Console.Write("Please enter your guess: ");
            char guess = char.Parse(Console.ReadLine());
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == guess)
                {
                    hangman[i] = guess;
                }
            }
        }
        Console.WriteLine(hangman);
        Console.ReadLine();

        bool AreArraysEqual(char[] array1, char[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }

            return true;
        }

    }
}
