using System;

partial class Program
{
    static void Main(string[] args )
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        // letter grading
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // "-" and "+" on all letters 
        if (letter != "F" && letter != "A")
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // "-" and "+" A and F letters
        if (letter == "A" && grade < 95)
        {
            sign = "-";
        }
        if (letter == "F")
        {
            sign = "";
        }

        // actaul grades
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Performance
        if (grade >= 70)
        {
Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("Don't give up—keep at it, and you'll succeed next time!");
        }
    }


}
