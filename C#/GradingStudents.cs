namespace Q5
{
    internal class Program
    {
        static void Main()
        {
            int passedCount = 0;
            int failedCount = 0;
            int classSize = 0; 
            int[] grades = new int[classSize];
            
            Console.WriteLine("Enter the grades:");
            for (int i = 0; i < classSize; i++)
            {
                int gradeInput;

                do
                {
                    gradeInput = int.Parse(Console.ReadLine());

                    if (gradeInput<=100&&gradeInput>=0)
                    {
                        int grade = int.Parse(gradeInput);

                        if (grade >= 50)
                        {
                            passedCount++;
                        }
                        else
                        {
                            failedCount++;
                        }
                        grades[i] = grade;
                        break;
                    }

                    Console.WriteLine("Invalid grade. Please enter a valid grade between 0-100");
                } while (true);
            }

            Console.WriteLine("{0} has passed the class {1} has failed.", passedCount, failedCount);

            Console.WriteLine("# of A+ is {0}", CountGrade(grades, 95, 100));
            Console.WriteLine("# of A is {0}", CountGrade(grades, 90, 94));
            Console.WriteLine("# of B+ is {0}", CountGrade(grades, 80, 89));
            Console.WriteLine("# of B is {0}", CountGrade(grades, 70, 79));
            Console.WriteLine("# of C is {0}", CountGrade(grades, 60, 69));
            Console.WriteLine("# of D is {0}", CountGrade(grades, 50, 59));
            Console.WriteLine("# of E is {0}", CountGrade(grades, 40, 49));
            Console.WriteLine("# of F is {0}", CountGrade(grades, 0, 39));
        }

        static int CountGrade(int[] grades, int smaller, int bigger)
        {
            int count = 0;
            foreach (int grade in grades)
            {
                if (grade >= smaller && grade <= bigger)
                {
                    count++;
                }
            }
            return count;
        }
    }
}