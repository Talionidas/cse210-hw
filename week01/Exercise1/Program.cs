using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your first name? ");   //input the first name
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");    //input the last name
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}.");   //this displays the full name all on one line with Bond style
    }
}