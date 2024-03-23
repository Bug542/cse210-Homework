using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base("Breathing", "helps you relax by guiding you through a breathing exercise.")
    {

    }

    // Override the PerformActivity Method
    protected override void PerformActivity()
    {
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(6); // Show count down for 6 seconds

            if ((DateTime.Now - startTime).TotalSeconds < _duration)
            {
                Console.Write("Now Breathe out...");
                ShowCountDown(6); // Show count down for 6 seconds
            }

            Console.WriteLine();
        }
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
}