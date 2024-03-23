using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] _prompts = {
        "People you appreciate",
        "Your personal strengths",
        "People you have helped this week",
        "Times you felt the Holy Ghost this month",
        "Your personal heroes"
    };

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Length)];
    }

    // Method to show countdown with an animation
    private void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); //Pause for 1 second
            Console.Write("\b \b");
        }

        Console.WriteLine(); //Move to the next line after count down
    }

    public ListingActivity() : base("Listing", "Helps you reflect on the good things in your life by listing as many as you can.")
    {
    }

    protected override void PerformActivity()
    {
        // Display a message indicating the start of the listing activity
        Console.WriteLine("List as many responces to the following prompt");

        // Display the prompt for the user to consider
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");

        // Display a message instructing the user to start listing items
        Console.Write("You may begin in...");
        ShowCountDown(3);

        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(_duration);

        int itemCount = 0;

        while (DateTime.Now - startTime < duration)
    {
        itemCount++;
        Console.Write($"Item {itemCount}: ");
        string item = Console.ReadLine();
        // Add item to the list or perform any necessary logic
        Thread.Sleep(1000); // Pause for 1 second between items
    }

    // Display the total number of items entered
    Console.WriteLine($"Total items entered: {itemCount}");
    }
}