using System.IO;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Welcome to the mindfulness program!");
        bool run_program = true;

        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while(run_program) {
            MainMenu();
            string choice = Console.ReadLine(); // User choice
            Console.Clear();

            if(choice=="1"){
                Console.Clear();
                Activity breathing = new BreathingActivity();
                breathing.intro();
                breathingCount++;
                Console.Clear();
            }
            else if(choice=="2"){
                Console.Clear();
                Activity reflecting = new ReflectingActivity();
                reflecting.intro();
                reflectingCount++;
                Console.Clear();
            }
            else if(choice=="3"){
                Console.Clear();
                Activity listing = new ListingActivity();
                listing.intro();
                listingCount++;
                Console.Clear();
            }
            else if(choice=="4"){
                Console.WriteLine("\nActivity Log:");
                Console.WriteLine($"Breathing Activity: {breathingCount} times");
                Console.WriteLine($"Reflecting Activity: {reflectingCount} times");
                Console.WriteLine($"Listing Activity: {listingCount} times");
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
            else if(choice=="5"){
                run_program = false;
            }
            else {
                Console.WriteLine("Try Again.");
            }
        }
    }
    public static void MainMenu() {
        Console.WriteLine("Please enter the numeric option below for the activity you would like to do:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. View Activity Log");
        Console.WriteLine("5. Quit Program");
        Console.Write("Enter your option: ");
    }
}

//added a log option that keeps track of each completed activity and the number of completion of said activity.