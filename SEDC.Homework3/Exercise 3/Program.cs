using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2

            /* Make a new console application called StudentGroup
                * Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
                * Get a number from the console between 1 and 2 and print the students from that group in the console.
                * Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
                * Test Data:
                          Enter student group: (there are 1 and 2 )
                             1
                * Expected Output:
                     The Students in G1 are:
                     -Zdravko
                     -Petko
                     -Stanko
                     -Branko
                     -Trajko
              */
            #endregion

            string[] studentsG1 = new string[5] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[5] {"Darko", "Dando", "Ace" ,"Dean", "Tea" };

            int one; 

            bool isValid = int.TryParse(Console.ReadLine(), out one);

            if(one == 1)
            {
                Console.WriteLine("The students in G1 are: ");
                foreach (var item in studentsG1)
                {
                    Console.WriteLine(item);
                }
            }
            else if (one == 2)
            {
                Console.WriteLine("The students in G2 are: ");
                foreach (var item in studentsG2)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Inavlid number!Try 1 or 2.");
            }

            Console.ReadLine();
        }
    }
}
