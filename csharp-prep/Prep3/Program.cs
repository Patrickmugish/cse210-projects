using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep3 Activity");
        string playAgain;

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        //Used a do-while loop to allow multiple plays of the game.
        do
        {
            // Picking a random number from 1 to 100.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            // do-while loop used here.
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                guessCount++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    // Developed answer including the guesscount.
                    Console.WriteLine($"You guessed it, in {guessCount} guesses!");
                }
            }

            // Ask the user if they want to play again
            do
            {
                Console.Write("Do you want to play again? (yes/no): ");
                playAgain = Console.ReadLine().ToLower();

                if (playAgain != "yes" && playAgain != "no")
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }

            } while (playAgain != "yes" && playAgain != "no");

            if (playAgain == "no")
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
            }

        } while (playAgain == "yes");
    }
}