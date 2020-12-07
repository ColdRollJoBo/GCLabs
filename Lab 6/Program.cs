using System;
using static System.Console;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rolledDie = new Random();
            int userDieSides = 0;
            int die1Result = 0;
            int die2Result = 0;


            WriteLine("How many dice would you like to throw? (1 or 2)");
            int amountOfDiceRolled = int.Parse(ReadLine());

            switch (amountOfDiceRolled)
            {
                case 1:
                    WriteLine("Enter the number of sides you would like your die to have.");
                    // This is where the user will set the amount of sides the die will have. ie 6, 8 ,10, 20 etc. 
                    userDieSides = int.Parse(ReadLine());
                    // This variable is the result that the die has rolled, after running through the diceroll method.
                    die1Result = diceRoll(userDieSides);
                    WriteLine($"You rolled a {die1Result}");
                    break;
                case 2:
                    WriteLine("Will your dice have the same amount of sides? y/n");
                    string userAnswer = ReadLine().ToLower();
                    if (userAnswer == "y")
                    {
                        WriteLine("Please enter the number of sides your dice will have");
                        // This is where the user will set the amount of sides the die will have. ie 6, 8 ,10, 20 etc. 
                        userDieSides = int.Parse(ReadLine());
                        // This variable is the result that the die has rolled, after running through the diceroll method.
                        die1Result = diceRoll(userDieSides);
                        die2Result = diceRoll(userDieSides);
                        WriteLine($"Your first die rolled a {die1Result}\nyour second die rolled a {die2Result}\nfor a total of {die1Result + die2Result}");
                    }
                    // This else statement allows you to roll two dice with different amount of sides. 
                    else if (userAnswer == "n")
                    {
                        WriteLine("Please enter the number of sides for your first die");
                        int userDice1Sides = int.Parse(ReadLine());
                        WriteLine("Please enter the number of sides for your second die");
                        int userDice2Sides = int.Parse(ReadLine());
                        die1Result = diceRoll(userDice1Sides);
                        die2Result = diceRoll(userDice2Sides);
                        WriteLine($"Your {userDice1Sides} sided die rolled a {die1Result}\nyour {userDice2Sides} sided die rolled a {die2Result}\nfor a total of {die1Result + die2Result}");
                    }
                    break;

            }

        }
        static int diceRoll(int numberOfSides)
        {
            // Adding +1 to the numberOfSides because the max value is exclusive.
            int rolledNumber = new Random().Next(1, numberOfSides + 1);
            return rolledNumber;

        }
    }
}
