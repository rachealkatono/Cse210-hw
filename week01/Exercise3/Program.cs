using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guess My Number Game!");

        Random random = new Random();
        string playAgain;

        do
        {
            Console.WriteLine("\nLet's begin! You can either pick the magic number or let the computer generate one.");
            Console.Write("Enter 'manual' to pick the number yourself or 'random' to let the computer choose: ");
            string mode = Console.ReadLine().Trim().ToLower();

            int magicNumber;
            if (mode == "manual")
            {
                Console.Write("What is the magic number? ");
                while (!int.TryParse(Console.ReadLine(), out magicNumber) || magicNumber < 1 || magicNumber > 100)
                {
                    Console.Write("Invalid input. Please enter a number between 1 and 100: ");
                }
            }
            else
            {
                magicNumber = random.Next(1, 101);
                Console.WriteLine("The computer has picked a magic number between 1 and 100. Try to guess it!");
            }

            int guess = 0;
            int attempts = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations!🎉🎉🎉 You guessed it in {attempts} attempts.");
                }
            }

            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine().Trim().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Come back soon! 🎉");
    }
}
