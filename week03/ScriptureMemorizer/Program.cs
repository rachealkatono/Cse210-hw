using System;

class Program
{
    public static void Main()
    {
        var scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass."),
            new Scripture(new Reference("Ether", 12, 27), "If men come unto me I will show unto them their weakness."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Helaman", 5, 12), "It is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation."),
            new Scripture(new Reference("3 Nephi", 11, 29), "He that hath the spirit of contention is not of me, but is of the devil."),
        };

        var random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
                break;

            scripture.HideRandomWords(2);
        }
    }
}
    
