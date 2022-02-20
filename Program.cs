using System;

namespace LineComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            if (CheckIfLineAreEqual.EqualityOfLine() == true)
            {
                Console.WriteLine("Lines are equal");
            }
            else 
            {
                Console.WriteLine("Lines are not equal");
            }


        }
    }
}