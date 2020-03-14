using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            /*Make a console application called SumOfEven.
             * Inside it create an array of 6 integers.Get numbers from the input,
             * find and print the sum of the even numbers from the array:

                Test Data:
                Enter integer no.1:
                4
                Enter integer no.1:
                3
                Enter integer no.1:
                7
                Enter integer no.1: 
                3
                Enter integer no.1:
                2
                Enter integer no.1:
                8
                Expected Output:
                The result is: 14
                */
            #endregion

            Console.WriteLine("Please enter five numbers: ");

            int numberOne;
            bool isValid1 = int.TryParse(Console.ReadLine(), out numberOne);

            int numberTwo;
            bool isValid2 = int.TryParse(Console.ReadLine(), out numberTwo);

            int numberThree;
            bool isValid3 = int.TryParse(Console.ReadLine(), out numberThree);

            int numberFour;
            bool isValid4 = int.TryParse(Console.ReadLine(), out numberFour);

            int numberFive;
            bool isValid5 = int.TryParse(Console.ReadLine(), out numberFive);

            int[] arrayOfNumbers = new int[5] { numberOne, numberTwo, numberThree, numberFour, numberFive };

            int sumOfNumbers = 0;

            foreach (var item in arrayOfNumbers)
            {
                if (item % 2 == 0)
                {
                    sumOfNumbers += item;

                }
            }

            Console.WriteLine("The sum of even numbers is: " + sumOfNumbers);

            Console.ReadLine();


        }
    }
}
