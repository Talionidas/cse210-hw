using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");   //asking for numeric input
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = ""; //setting the definition to empty so it can be changed to the right letter

        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("you did it, amazing!");  //congratulations message
        }

        else
        {
            Console.WriteLine("don't let this get to you, you will do better next time, I believe in you!!"); //message to encourage them for the next time
        }
    }
}