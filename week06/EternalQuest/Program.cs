// Enhanced Eternal Quest Program
// Added Features:
// 1. Level System - Users gain levels based on score milestones
//    - Gain a new level every 1000 points
//    - Celebratory message with 🎉 when leveling up
//    - Shows progress to next level
//
// 2. Daily Streak System
//    - Tracks consecutive daily logins
//    - Awards bonus points (10 points × streak days)
//    - Encourages daily program engagement
//    - Resets if a day is missed
//
// 3. Negative Goals Feature
//    - Allows tracking of bad habits
//    - Subtracts points when bad habits occur
//    - Adds accountability to the goal system
//
// 4. Enhanced Statistics Display
//    - Shows current level
//    - Displays streak count
//    - Shows total score
//    - Provides immediate feedback
//
// These features exceed the base requirements by adding multiple
// gamification elements (levels, streaks), implementing negative goals,
// and creating a more engaging experience with both positive reinforcement
// and accountability mechanics.
// Main program class
class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;
    static int level = 1;
    static DateTime lastLogin = DateTime.Now;
    static int streakDays = 0;

    static void Main()
    {
        LoadGoals();
        CheckDailyStreak();
        
        while (true)
        {
            Console.WriteLine($"\nEternal Quest Program - Level {level}");
            Console.WriteLine($"Score: {score} | Streak: {streakDays} days");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Show Stats");
            Console.WriteLine("5. Create Negative Goal");
            Console.WriteLine("6. Save & Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ShowGoals(); break;
                case "4": ShowStats(); break;
                case "5": CreateNegativeGoal(); break;
                case "6": SaveGoals(); return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void ShowStats()
    {
        Console.WriteLine($"\nLevel: {level}");
        Console.WriteLine($"Total Score: {score}");
        Console.WriteLine($"Daily Streak: {streakDays} days");
        Console.WriteLine($"Goals Created: {goals.Count}");
        Console.WriteLine($"XP to next level: {(level * 1000) - score}");
    }

    static void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Choose type: 1. Simple  2. Eternal  3. Checklist");
        string type = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1") goals.Add(new SimpleGoal(name, points));
        else if (type == "2") goals.Add(new EternalGoal(name, points));
        else if (type == "3")
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
        }
        Console.WriteLine("Goal created successfully!");
    }

    static void CreateNegativeGoal()
    {
        Console.Write("Enter bad habit to avoid: ");
        string name = Console.ReadLine();
        Console.Write("Enter points to lose: ");
        int points = int.Parse(Console.ReadLine());
        goals.Add(new NegativeGoal(name, points));
        Console.WriteLine("Negative goal created! Avoid this to maintain your score!");
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Enter goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent(ref score);
            CheckLevelUp();
        }
        else
            Console.WriteLine("Invalid goal number.");
    }

    static void ShowGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Serialize()}");
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine($"{score},{level},{streakDays},{lastLogin}");
            foreach (Goal goal in goals)
                writer.WriteLine(goal.Serialize());
        }
        Console.WriteLine("Goals saved successfully!");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            string[] stats = lines[0].Split(',');
            score = int.Parse(stats[0]);
            level = int.Parse(stats[1]);
            streakDays = int.Parse(stats[2]);
            lastLogin = DateTime.Parse(stats[3]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                switch (parts[0])
                {
                    case "Simple": 
                        goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2]))); 
                        break;
                    case "Eternal": 
                        goals.Add(new EternalGoal(parts[1], int.Parse(parts[2]))); 
                        break;
                    case "Checklist":
                        goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), 
                            int.Parse(parts[3]), int.Parse(parts[5])));
                        break;
                    case "Negative":
                        goals.Add(new NegativeGoal(parts[1], int.Parse(parts[2])));
                        break;
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
    }

    static void CheckLevelUp()
    {
        int newLevel = (score / 1000) + 1;
        if (newLevel > level)
        {
            Console.WriteLine($"\n🎉 LEVEL UP! You are now level {newLevel}!");
            level = newLevel;
        }
    }

    static void CheckDailyStreak()
    {
        if ((DateTime.Now - lastLogin).Days == 1)
        {
            streakDays++;
            int bonus = streakDays * 10;
            score += bonus;
            Console.WriteLine($"Daily Streak Bonus: +{bonus} points!");
        }
        else if ((DateTime.Now - lastLogin).Days > 1)
        {
            streakDays = 0;
            Console.WriteLine("Streak reset! Log in daily to maintain your streak!");
        }
        lastLogin = DateTime.Now;
    }
}