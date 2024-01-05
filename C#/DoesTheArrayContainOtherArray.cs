using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size1, size2;
            bool isEqual = true;
            
            Console.Write("Enter the size of the first array : ");
            size1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size1];
            for(int i=0;i<size1; i++)
            {
                Console.Write("Enter {0}. value for the first array : ",i+1);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the size of the second array : ");
            size2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                Console.Write("Enter {0}. value for the second array : ", i + 1);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            if(size1==size2)
            {
                for(int i=0; i < size1;i++)
                {
                    bool flag = false;

                    for(int j=0; j<size1; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            flag = true;
                            break;
                        }
                           
                    }

                    if(!flag)
                    {
                        isEqual = false;
                        break;
                    }
                }
                if(isEqual==true)
                    Console.WriteLine("They are same :)");
                else
                    Console.WriteLine("They are not same :(");

            }
            else
            {
                Console.WriteLine("They are not same :(");
            }

        }
    }
}