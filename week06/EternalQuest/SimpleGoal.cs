// SimpleGoal: Completed once, earns points
class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent(ref int score)
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            score += Points;
            Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }

    public override string GetStatus() => IsCompleted ? "[X]" : "[ ]";
    public override string Serialize() => $"Simple,{Name},{Points},{IsCompleted}";
}