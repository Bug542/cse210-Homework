using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] _prompts = { "Think of a time you stood up for someone else.", "Think of a time you did something really difficult", "Think of a time you helped someone in need", "Think of a time you did something really helpless" };

    public ReflectionActivity() : base("Reflection", "Helps you reflect on times when you've shown strength and resilience.")
    {
    }

    protected override void PrepareForActivity()
    {
        base.PrepareForActivity();
        Console.WriteLine("Consider the following prompt...");
        Console.WriteLine();
        // Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected override void PerformActivity()
    {
        bool initialPromptDisplayed = false;
        foreach (var prompt in _prompts)
        {
           if(!initialPromptDisplayed)
           {
            Console.WriteLine($"Prompt: {prompt}");
            Console.WriteLine();
            Console.WriteLine("Whenever you have something in mind, press enter");
            Console.ReadLine();
            Console.Write("Beginnig Soon...");
            SpinnerAnimation();
            Console.WriteLine();
            initialPromptDisplayed = true;
           }
            Console.WriteLine();
            DisplayRandomQuestion();
            SpinnerAnimation();
        }
        Console.WriteLine();
    }

    private void DisplayRandomQuestion()
    {
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random random = new Random();
        string randomQuestion = questions[random.Next(questions.Length)];

        Console.Write($"Question: {randomQuestion}");
        SpinnerAnimation();
    }
}