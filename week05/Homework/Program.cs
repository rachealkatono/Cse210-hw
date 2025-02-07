using System;

class Program
{
    static void Main(string[] args)
    {
        // Updated assignment details
        Assignment assignment = new Assignment("Roike Smith", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment1 = new MathAssignment("Ruth Johnson", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Davis Brown", "Software Development", "The Impact of Artificial Intelligence");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}
