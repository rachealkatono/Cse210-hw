using System;
using System.IO;

public class Program
{
    static int listingCount = 0;
    static int breathingCount = 0;
    static int reflectionCount = 0;
    static int gratitudeCount = 0; // New activity count

    static void Main(string[] args)
    {
        LoadActivityLog(); // Load previous session data

        while (true) // Keep looping until user chooses Exit
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Listing Activity");
            Console.WriteLine("2. Breathing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Gratitude Activity (NEW)"); // New activity
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            // Validate user input
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number from 1 to 5.");
                Console.ReadKey();
                continue;
            }

            Console.Clear(); // Clear screen for better readability

            switch (choice)
            {
                case 1:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;
                case 2:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;
                case 3:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    reflectionCount++;
                    break;
                case 4:
                    GratitudeActivity gratitude = new GratitudeActivity();
                    gratitude.Run();
                    gratitudeCount++;
                    break;
                case 5:
                    SaveActivityLog(); // Save log before exiting
                    Console.WriteLine("Goodbye!");
                    return; // Exit the loop and end program
                default:
                    Console.WriteLine("Invalid choice! Please enter a number from 1 to 5.");
                    break;
            }

            Console.WriteLine($"\nActivity Counts: Listing ({listingCount}), Breathing ({breathingCount}), Reflection ({reflectionCount}), Gratitude ({gratitudeCount})");
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey(); // Wait before showing the menu again
        }
    }

    // Save activity count log to a file
    static void SaveActivityLog()
    {
        using (StreamWriter writer = new StreamWriter("activity_log.txt"))
        {
            writer.WriteLine($"{listingCount},{breathingCount},{reflectionCount},{gratitudeCount}");
        }
    }

    // Load activity count log from a file
    static void LoadActivityLog()
    {
        if (File.Exists("activity_log.txt"))
        {
            string[] data = File.ReadAllText("activity_log.txt").Split(',');
            if (data.Length == 4)
            {
                listingCount = int.Parse(data[0]);
                breathingCount = int.Parse(data[1]);
                reflectionCount = int.Parse(data[2]);
                gratitudeCount = int.Parse(data[3]);
            }
        }
    }
}

/*
Enhancements to exceed requirements:
1. Added a new "Gratitude Activity" to expand the options.
2. Implemented a session activity log that tracks how many times each activity has been performed.
3. Ensured that prompts/questions do not repeat until all have been used.
4. Saved and loaded the log file ("activity_log.txt") to keep activity counts persistent across sessions.
5. Displayed the activity count after each session to give feedback to the user.

These changes improve user engagement, persistence, and overall experience.
*/
