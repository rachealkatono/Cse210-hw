// ChecklistGoal: Must be completed multiple times, with a bonus
class ChecklistGoal : Goal
{
    private int TargetCount;
    private int CurrentCount;
    private int BonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent(ref int score)
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            score += Points;
            Console.WriteLine($"Recorded '{Name}' ({CurrentCount}/{TargetCount}). You earned {Points} points.");
            
            if (CurrentCount == TargetCount)
            {
                IsCompleted = true;
                score += BonusPoints;
                Console.WriteLine($"Goal '{Name}' completed! Bonus {BonusPoints} points awarded!");
            }
        }
    }

    public override string GetStatus() => IsCompleted ? "[X]" : $"[{CurrentCount}/{TargetCount}]";
    public override string Serialize() => $"Checklist,{Name},{Points},{TargetCount},{CurrentCount},{BonusPoints}";
}
