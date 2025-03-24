using System;
using System.Transactions;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            StartGame();

            //Creating a random number generator
            Random random = new Random();
            //Creating a variable to store the number of guesses
            int guessCount = 0;
            //Generating a random number between 1 and 100
            int randomNumber = random.Next(1, 101);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();
                Console.Write("Type your lucky number here -> ");
                int number = int.Parse(Console.ReadLine());
                Console.ResetColor();

                // Getting the users input and checking if the guess is correct
                if (number < randomNumber / 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your number is too low! Try again.");
                    Console.ResetColor();
                    guessCount++;
                    continue;
                }
                else if (number == randomNumber / 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You're right in the middle! Try again.");
                    Console.ResetColor();
                    guessCount++;
                    continue;
                }
                else if (number > randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your number is too high! Try again.");
                    Console.ResetColor();
                    guessCount++;
                    continue;
                }
                else if (number == randomNumber)
                {
                    guessCount++;
                    break;
                }
                else if (number > randomNumber / 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You're right in the middle! Try again.");
                    Console.ResetColor();
                    guessCount++;
                    continue;
                }
                
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Great job! You guessed the number!!!");
            Console.ResetColor();
            Console.WriteLine($"Number of guesses: {guessCount}");
        }


        private static void StartGame()
        {
            Loading();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("         <<<Welcome to the number guessing game!!!>>>           ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Type a number between 1 and 100 and see if it's your lucky day!");
            Console.Rese

        }

        private static void Loading()
        {
            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            Console.Clear();


        }
    }
}
