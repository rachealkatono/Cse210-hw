using System;
using System.Collections.Generic;
using System.IO;

// Base class for all goals
abstract class Goal
{
    protected string Name;
    protected int Points;
    protected bool IsCompleted;

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent(ref int score);
    public abstract string GetStatus();
    public abstract string Serialize();
}