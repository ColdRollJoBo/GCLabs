using System;
using static System.Console;
namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("This program will calculating the Factorial of a number.\nEnter a number between 1 and 10");
            long factResult = 0;
            string userAnswer = null;
           
            do
            {
                int userNum = int.Parse(ReadLine());
                if (userNum >= 1 && userNum <= 10)
                {
                    long factorial = userNum;
                    for (long i = factorial; i > 1; i--)
                    {
                        factResult = factorial *= i - 1;
                    }

                    WriteLine($"Factorial of {userNum} is {factResult}");
                    WriteLine("Would you like to find the factorial of another number? (y/n).\n");
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

            WriteLine("Thank you for using the factorial finding program.");

        }
    }
}
