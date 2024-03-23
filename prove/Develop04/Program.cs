using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;

        while(continueProgram)
        {
            // Display the Menu
            Console.WriteLine("Menu");
            Console.WriteLine("====");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Read the user's choice
            string choice = Console.ReadLine();

            // Process the user's choice
            switch(choice)
            {
                case "1":
                    // Start Breathing Activity
                    BreathingActivity breathingActivity = new BreathingActivity();
                    RunActivity(breathingActivity);
                    break;
                case "2":
                    // Start Reflection Activity
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    RunActivity(reflectionActivity);
                    break;
                case "3":
                    // Start Listing Activity
                    ListingActivity listingActivity = new ListingActivity();
                    RunActivity(listingActivity);
                    break;
                case "4":
                    // Quit the program
                    continueProgram = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    // Invalid choice
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void RunActivity(Activity activity)
    {
        // Set the duration of the activity
        Console.Write("How long would you like to do this in seconds: ");
        activity.SetDuration(int.Parse(Console.ReadLine()));

        // Run Activity
        activity.Run();
    }
}