using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first string: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string input2 = Console.ReadLine();

            char[] char1 = new char[input1.Length];
            char[] char2 = new char[input2.Length];

            for(int i = 0; i < input1.Length; i++)
            {
                char1[i] = input1[i];
            }
            for(int j = 0; j < input2.Length; j++)
            {
                char2[j] = input2[j];
            }
            int minLength = input1.Length;
            if(input1.Length > input2.Length)
            {
                minLength = input2.Length;
            }
            for(int z= 0;z< minLength;z++)
            {
                if (char1[z] == char2[z])
                    continue;
                else if (char1[z] < char2[z])
                    Console.WriteLine("First string comes before second string.");
                else if (char1[z] > char2[z])
                    Console.WriteLine("Second string comes before first string");
            }
            Console.ReadLine();
        }
    }
}
