// EternalGoal: Never fully complete, gains points every time recorded
class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent(ref int score)
    {
        score += Points;
        Console.WriteLine($"Recorded '{Name}'. You earned {Points} points.");
    }

    public override string GetStatus() => "[∞]";
    public override string Serialize() => $"Eternal,{Name},{Points}";
}
