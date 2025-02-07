using System;

public class Program
{
    static void Main(string[] args)
    {
        while (true) // Keep looping until user chooses Exit
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Listing Activity");
            Console.WriteLine("2. Breathing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            // Validate user input
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number from 1 to 4.");
                Console.ReadKey();
                continue;
            }

            Console.Clear(); // Clear screen for better readability

            switch (choice)
            {
                case 1:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case 2:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case 3:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    return; // Exit the loop and end program
                default:
                    Console.WriteLine("Invalid choice! Please enter a number from 1 to 4.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey(); // Wait before showing the menu again
        }
    }
}
