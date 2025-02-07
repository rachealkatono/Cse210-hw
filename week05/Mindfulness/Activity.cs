public class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {name} Activity! {description} Please enter the duration of the activity in seconds.");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You have completed the {name} Activity for {duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b");
            Console.Write("|");           
            Thread.Sleep(100);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin!");
        Thread.Sleep(2000);
        ActivitySpecificRun();
        Console.WriteLine("Well done!");
        DisplayEndingMessage();
    }

    protected virtual void ActivitySpecificRun()
    {
     
    }
}