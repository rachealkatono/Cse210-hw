// NegativeGoal: Tracks bad habits and deducts points when recorded
class NegativeGoal : Goal
{
    public NegativeGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent(ref int score)
    {
        score -= Points;
        Console.WriteLine($"Oh no! Lost {Points} points for {Name}");
    }

    public override string GetStatus() => "[!]";
    public override string Serialize() => $"Negative,{Name},{Points}";
}
