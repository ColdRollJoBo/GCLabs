using System;
using static System.Console;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("We are going to learn our squares and cubes.\nLet's start by entering a number between 1 and 10\n");
            string userAnswer = "n";

            do
            {
                int userNumber = int.Parse(ReadLine());
                if (userNumber >= 1 && userNumber <= 10)
                {
                    WriteLine("{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed");
                    WriteLine("{0,-10} {1,-10} {2,-10}", "======", "=======", "=====");
                    for (int i = 1; i <= userNumber; i++)
                    {
                        WriteLine("{0,-10} {1,-10} {2,-10}", i, NumberSquared(i), NumberCubed(i));
                    }
                    WriteLine("Would you like to enter another number? yes or no (y/n)");
                    userAnswer = ReadLine().ToLower();
                    if (userAnswer == "y")
                    {
                        WriteLine("Please enter another number.");
                    }
                }
                else
                {
                    WriteLine("The number you typed is not between 1 and 10. Please try again\nEnter another number");
                }
            } while (userAnswer == "y");
            WriteLine("Thank you! I hope you enjoyed learning with me today.");

        }

        static int NumberCubed(int num)
        {
            return num * num * num;
        }
        static int NumberSquared(int num)
        {
            return num * num;
        }
    }
}
