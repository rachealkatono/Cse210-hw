using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        List<int> numbers = new List<int>();

        int input;

        do
        {
            Console.Write("Enter number: ");
            
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
  if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        // Core Requirements
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int maxNumber = int.MinValue;
            foreach (int num in numbers)
            {
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            Console.WriteLine($"The largest number is: {maxNumber}");
        }

        // Stretch Challenges
        if (numbers.Count > 0)
        {
            int smallestPositive = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}