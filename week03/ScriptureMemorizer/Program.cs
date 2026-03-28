using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture>John = new List<Scripture>();
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.", new Reference("John", 3, 16));
        
    int totalHiddenWords = 0;
    int rounds = 0;

        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine($"\nRounds: {rounds} | Total Words Hidden: {totalHiddenWords}");

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("\nProgram ending.");
                break;
            }

            int hiddenThisRound = scripture.HideRandomWords();

            Console.WriteLine($"You hid {hiddenThisRound} words this round!");

            if (hiddenThisRound > 0)
            {
                rounds++;
                totalHiddenWords += hiddenThisRound;
            }
        }
    }
}

// added a way to track rounds and how many total words have been hidden, so user can get a concept of where they get stuck and how far they can make it if they choose to quit early.