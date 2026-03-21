using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture>John = new List<Scripture>();
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.", new Reference("John", 3, 16));
        
        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

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

            scripture.HideRandomWords();

        }
    }
}