using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create different activities
        var running = new Running(new DateTime(2025, 09, 2), 30, 3.0); // 30 min running with 3 miles distance
        var cycling = new Cycling(new DateTime(2025, 09, 2), 45, 12.0); // 45 min cycling with 12 mph speed
        var swimming = new Swimming(new DateTime(2025, 09, 2), 30, 20); // 30 min swimming with 20 laps
        var hiking = new Hiking(new DateTime(2025, 09, 2), 60, 500); // 60 min hiking with 500 meters elevation gain

        // Put them in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming, hiking };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
