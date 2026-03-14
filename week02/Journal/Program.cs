using System;
using System.IO;
class Program
{
    static void Main(string[] args)
{
        Journal journal = new Journal();

        Console.WriteLine("Welcome to Your Daily Journal!");
    
        //Loop for Menu
        while (true) {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Please select an option (1-5) ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                journal.AddEntry();
                break;

                case "2":
                journal.DisplayEntries();
                break;

                case "3":
                journal.LoadFromFile();
                break;

                case "4":
                journal.SaveToFile();
                break;

                case "5":
                Console.WriteLine("Don't forget to come back next time!");
                return;

                //Set default to return to selection, so if answer is not within range user can input ranged numbers again
                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5.");
                break;
            }
        }
    }
}