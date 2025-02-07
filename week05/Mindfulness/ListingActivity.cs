public class ListingActivity : Activity
{
    private new int duration;
    private string[] list;
    private string[] prompts = new string[] { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

    protected override void ActivitySpecificRun()
    {
        Console.WriteLine($"Welcome to the Listing Activity! This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. Please enter the duration of the activity in seconds.");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin!");
        Thread.Sleep(2000);
        Console.WriteLine("Think of the following prompt:");
        Console.WriteLine(GetListItemPrompt());
        Console.WriteLine("You have 5 seconds to prepare...");
        ShowCountDown(5);
        Console.WriteLine("Begin listing items:");
        DateTime start = DateTime.Now;
        list = new string[duration];
        for (int i = 0; i < duration; i++)
        {
            if ((DateTime.Now - start).TotalSeconds > duration)
            {
                Console.WriteLine("Thank you!");
                break;
            }
            Console.Write($"{i + 1}. ");
            
            list[i] = Console.ReadLine();
        }
        DateTime end = DateTime.Now;
        TimeSpan timeTaken = end - start;
        Console.WriteLine($"You listed {list.Length} items in {timeTaken.TotalSeconds} seconds.");
    }
    
    public ListingActivity()
    {
        name = "Listing";
    }

    private string GetListItemPrompt()
    {
        Random rnd = new Random();
        return prompts[rnd.Next(prompts.Length)];
    }
}