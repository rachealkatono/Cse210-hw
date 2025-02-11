// Program.cs - Entry point of the application
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Shape Area Calculator!");
        List<Shape> shapes = new List<Shape>
        {
            new Square("Crimson Red", 4.5),
            new Rectangle("Ocean Blue", 6, 2.5),
            new Circle("Emerald Green", 3.2)
        };

        Console.WriteLine("\nCalculating areas of different shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Computed Area: {shape.GetArea():F2} square units");
        }

        Console.WriteLine("\nThank you for using the Shape Area Calculator! Have a great day!");
    }
}
