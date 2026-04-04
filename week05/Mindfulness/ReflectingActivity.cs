class ReflectingActivity : Activity {
    
    int duration;
    public override void intro()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        duration = getDuration();
        runActivity(); 
    }

    public override void runActivity() {
        Console.Clear();
        Console.WriteLine("Get ready..."); 
        Timer();

        string[] prompts = {
            " --- Think of a time when you stood up for someone else. ---\n",
            " --- Think of a time when you did something really difficult. ---\n",
            " --- Think of a time when you helped someone in need. ---\n",
            " --- Think of a time when you did something truly selfless. ---\n"
        };
        string[] questions = {
            "> Why was this experience meaningful to you?",
            "> Have you ever done anything like this before?",
            "> How did you get started?",
            "> How did you feel when it was complete?",
            "> What made this time different than other times when you were not as successful?",
            "> What is your favorite thing about this experience?",
            "> What could you learn from this experience that applies to other situations?",
            "> What did you learn about yourself through this experience?",
            "> How can you keep this experience in mind in the future?"
        };

        Random random = new Random();
        int rand = random.Next(0, prompts.Length);
        
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine(prompts[rand]);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.\n");

        Console.Write("You may begin in:  ");
        for (int k = 5; k > 0; k--) {
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write(Convert.ToString(k));
            Thread.Sleep(1000);
        }

        Console.Clear();

        int temp_duration = duration;
        
        // cycling through questions in the list until the time reaches 0
        foreach (string question in questions) {

            if (temp_duration <= 0) {
                break;
            }

            Console.WriteLine(question);
            Timer();
            temp_duration = temp_duration - 5;
        }

        Console.WriteLine("\nWell done!");
        Console.WriteLine("\nYou have completed " + duration + " seconds of the Reflecting Activity.");
        Timer();
        Console.Clear();
    }
}