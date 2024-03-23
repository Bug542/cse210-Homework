using System;
using System.Threading;

public class Activity
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    // The Rum Method
    public void Run()
    {
        DisplayStartMessage();
        PerformActivity();
        DisplayEndingMessage();
    }

    // Method of the duration
    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    // Method for the Spinner
    protected void SpinnerAnimation()
    {
        // |/-\|/-\|
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddMilliseconds(10000);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    // Method to display start message
    protected void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity: {_description}");
        PrepareForActivity();
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!");
        SpinnerAnimation(); //10 seconds animation
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} Activity in {_duration} seconds.");
    }

    // Virtual class to allow derived classes to prepare for the actiivy
    protected virtual void PrepareForActivity()
    {
        Console.WriteLine("Get ready ...");
        SpinnerAnimation(); //10 seconds animation
        Console.WriteLine();
    }

    // Virtual method  to allow  derived class to to define their specific  activity logic
    protected virtual void PerformActivity()
    {
        // This will be overridden by specific activities.
    }
}