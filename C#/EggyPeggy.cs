namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            string sentence, result = "";

            Console.WriteLine("Bir cümle giriniz:");
            sentence = Console.ReadLine();

            for (int i = 0; i < sentence.Length; i += 2)
            {
                string syllable = "";

                if (i + 1 >= sentence.Length)
                {
                    syllable = sentence.Substring(i, 1);
                }
                else
                {
                    syllable = sentence.Substring(i, 2);
                }

                string add = "";
                foreach (char letter in syllable)
                {
                    switch (letter)
                    {
                        case 'a':
                        case 'A':
                            add += "ga";
                            break;
                        case 'ı':
                        case 'I':
                            add += "gı";
                            break;
                        case 'o':
                        case 'O':
                            add += "go";
                            break;
                        case 'u':
                        case 'U':
                            add += "gu";
                            break;
                        case 'e':
                        case 'E':
                            add += "ge";
                            break;
                        case 'i':
                        case 'İ':
                            add += "gi";
                            break;
                        case 'ö':
                        case 'Ö':
                            add += "gö";
                            break;
                        case 'ü':
                        case 'Ü':
                            add += "gü";
                            break;
                        default:
                            add += letter;
                            break;
                    }
                }

                result += add;
            }

            Console.WriteLine("Kuş dilinde cümleniz : " + result);
        }
    }

}