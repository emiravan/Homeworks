using System.ComponentModel.Design;

namespace Q2
{
    internal class Program
    {
        static void Main()
        {
            double exitButton = 0,netSalary=0,taxRate=0;

            Console.WriteLine("-- You can exit with 0... --");

            for (int i = 1; ; i++)
            {
                Console.WriteLine("Enter the gross salary for {0}. employee",i);
                double grossSalary = double.Parse(Console.ReadLine());

                if (grossSalary == exitButton)
                {
                    break;
                }

                if (grossSalary >= 15000 && grossSalary <= 20000)
                {
                    taxRate = 0.1;
                }
                else if (grossSalary > 20000 && grossSalary <= 30000)
                {
                    taxRate = 0.12;
                }
                else if (grossSalary > 30000 && grossSalary <= 49999)
                {
                    taxRate = 0.15;
                }
                else if (grossSalary > 49999)
                {
                    taxRate = 0.2;
                }

                netSalary = (grossSalary - ((grossSalary * taxRate)*0.1)) - 150.5;

                Console.WriteLine("Net Salary: {0}",netSalary);
            }

            Console.ReadKey();
        }
    }
}