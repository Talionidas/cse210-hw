using System;

class ListingActivity : Activity {

    int duration;
    public override void intro()
    {
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        duration = getDuration();
        runActivity(); 
    }

    public override void runActivity() {
        Console.Clear();
        Console.WriteLine("Get ready..."); 
        Timer();

        string[] prompts = {
            " --- Who are people that you appreciate? ---\n",
            " --- What are personal strengths of yours? ---\n",
            " --- Who are people that you have helped this week? ---\n",
            " --- When have you felt the Holy Ghost this month? ---\n",
            " --- Who are some of your personal heroes? ---\n"
        };

        Random random = new Random();
        int rand = random.Next(0, prompts.Length);

        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");
        Console.WriteLine(prompts[rand]);
        
        Console.Write("You may begin in:  ");
        for (int k = 5; k > 0; k--) {
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write(Convert.ToString(k));
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        
        DateTime currentTime = DateTime.Now;

        int numberItems = 0;

        // Input while timer is still running
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("> ");
            Console.ReadLine();
            numberItems += 1;
        }

        Console.WriteLine("\nYou listed " + numberItems + " items!");
        Console.WriteLine("\nWell done!");
        Console.WriteLine("\nYou have completed " + duration + " seconds of the Reflecting Activity.");
        Timer();
        Console.Clear();
    }
}