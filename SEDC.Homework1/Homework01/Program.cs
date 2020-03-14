using System;
using System.Threading;
namespace SEDC.CSharp.Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic Light....");
            Thread.Sleep(1500);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("Red Light - STOP!" );
            Thread.Sleep(1500);

            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Yellow Light - Prepare.");
            Thread.Sleep(1500);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green Light - Go!");

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
