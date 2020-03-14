using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            int[] arrayOfNumbers = new int[5] {numberOne,numberTwo,numberThree,numberFour,numberFive };

            int sumOfNumbers = 0;

            foreach (var item in arrayOfNumbers )
            {
                sumOfNumbers += item;
            }

            Console.WriteLine("The sum is: " + sumOfNumbers);

            Console.ReadLine();
        }
    }
}
