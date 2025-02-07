public class BreathingActivity : Activity
{
    private void BreathIn()
    {
        Console.WriteLine("Breath in...");
        ShowSpinner(5);
        ShowTextAnimation("Inhale", 10, 1);
    }

    private void BreathOut()
    {
        Console.WriteLine("Breath out...");
        ShowSpinner(5);
        ShowTextAnimation("Exhale", 10, 0.5);
    }

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

    protected override void ActivitySpecificRun()
    {
        for (int i = 0; i < duration; i += 10)
        {
            BreathIn();
            BreathOut();
        }
    }

    public BreathingActivity()
    {
        name = "Breathing";
        description = "This activity is designed to help you relax and focus on your breathing.";
    }
}