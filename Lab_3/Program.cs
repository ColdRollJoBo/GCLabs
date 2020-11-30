using System;
using static System.Console;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the Lab 3 Challenge\nPlease follow the upcoming instructions.\n\nPLEASE ENTER YOUR NAME");
            string userName = ReadLine();
            string userAnswer;
            do
            {
                WriteLine($"Hello {userName}! Enter a number between 1 and 100");
                int userNumber = int.Parse(ReadLine());

                if (userNumber % 2 != 0 && userNumber < 60)
                {
                    WriteLine("The number you entered is ODD.");
                }
                else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 25)
                {
                    WriteLine("The number you have entered is Even and less than 25.");
                }
                else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
                {
                    WriteLine("The number you have entered is Even");
                }
                else if (userNumber % 2 == 0 && userNumber >= 60)
                {
                    WriteLine($"You have entered {userNumber} and it is Even");
                }
                else if (userNumber % 2 != 0 && userNumber >= 60)
                {
                    WriteLine($"{userNumber} is ODD and larger than 60");
                }

                WriteLine("Would you like to enter another number? yes or no (y/n)");
                userAnswer = ReadLine().ToLower();

            } while (userAnswer == "y" || userAnswer == "yes");

            WriteLine($"Thank you for playing {userName} please come back soon.");






        }
    }
}
