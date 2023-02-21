using System;

namespace LoopExercise // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a new instance of the random number generator
            Random rnd = new Random();
            
            // Variables
            bool isRunning = true;
            int number;

            // While loop that lets people restart the game
            while (isRunning)
            {
                // Select a number between 1-100
                number = rnd.Next(1, 100);

                // Prompt the player to guess the number
                Console.WriteLine("Guess the number, you have 5 tries.");

                // Give 5 turns to guess the number using a for loop
                for (int i = 0; i < 5; i++)
                {
                    int guess;

                    if (!int.TryParse(Console.ReadLine(), out guess)) // Checks if the guess is a number then checks if it is correct
                    {
                        Console.WriteLine("Please write a number.");
                    }else if (guess == number) // Runs if correct
                    {
                        Console.WriteLine($"You guessed the number {guess} and it was correct!");
                        break;
                    }
                    else if (guess > number) // Guess was too low
                    {
                        Console.WriteLine("Too Low.");
                    } else // Guess was too high
                    {
                        Console.WriteLine("Too High.");
                    }
                }



                // Ask the user if they want to restart
                Console.WriteLine("Would you like to play this again (Y/N)");

                var choice = Console.ReadKey(true).Key;

                // Check if they pressed no (assumes yes if its anything else)
                if (choice == ConsoleKey.N)
                {
                    isRunning = false;
                }
            }

            Console.WriteLine("Thanks for playing");
            Console.ReadKey(true);
        }
    }
}