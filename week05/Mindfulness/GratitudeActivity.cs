using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "What are three things you are grateful for today?",
        "Who in your life has made a positive impact on you?",
        "What is a small moment that brought you joy recently?",
        "What is something about yourself that you appreciate?",
        "What challenges have made you stronger?",
        "What is a simple pleasure you enjoy?",
    };

    private void ShowTextAnimation(string text, int duration, double speed)
    {
        int initialSize = 10;
        int finalSize = 30;
        double sizeIncrement = (finalSize - initialSize) / (duration / speed);

        for (int i = 0; i < duration; i++)
        {
            int currentSize = (int)(initialSize + (sizeIncrement * i));
            Console.WriteLine(text.PadLeft(currentSize));
            Thread.Sleep((int)(1000 * speed));
        }
    }

    private void ShowGratitudePrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"🌿 {prompt}");
        ShowSpinner(5); // Give time to reflect before listing
        ShowTextAnimation("Reflecting...", 10, 1);
    }

    private void StartListing()
    {
        Console.WriteLine("Now, list the things you are grateful for. Press Enter after each one.");
        List<string> responses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(30); // Set duration to 30 seconds for listing
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"\n🌟 You listed {responses.Count} things you are grateful for.");
    }

    protected override void ActivitySpecificRun()
    {
        ShowGratitudePrompt();
        StartListing();
    }

    public GratitudeActivity()
    {
        name = "Gratitude";
        description = "This activity helps you reflect on the positive aspects of your life by listing what you are grateful for.";
    }
}
