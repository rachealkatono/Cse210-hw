class ReflectionActivity : Activity
{
    private string[] prompts = new string[] { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", 
    "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private string[] questions = new string[] { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", 
    "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", 
    "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", 
    "How can you keep this experience in mind in the future?" };

    protected override void ActivitySpecificRun()
    {
        Console.WriteLine($"Welcome to the Reflection Activity! This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. Please enter the duration of the activity in seconds.");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin!");
        Thread.Sleep(2000);
        Console.WriteLine("Think of the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("You have 5 seconds to prepare...");
        ShowCountDown(5);
        Console.WriteLine("Begin reflecting:");
        DateTime start = DateTime.Now;
        for (int i = 0; i < duration; i += 10)
        {
            Console.WriteLine($"Question {i / 10 + 1}: {GetRandomQuestion()}");
            Console.WriteLine("You have 10 seconds to reflect...");
            ShowSpinner(10);
        }
        DateTime end = DateTime.Now;
        TimeSpan timeTaken = end - start;
        Console.WriteLine($"You reflected on {duration / 10} questions in {timeTaken.TotalSeconds} seconds.");
    }

    public ReflectionActivity()
    {
        name = "Reflection";
    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        return prompts[rnd.Next(prompts.Length)];
    }

    private string GetRandomQuestion()
    {
        Random rnd = new Random();
        return questions[rnd.Next(questions.Length)];
    }
}