public class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did you eat for breakfast?",
            "What activities have you done today?",
            "What are some goals you had for today?",
            "Did you read your scriptures?",
            "Did you help anyone today?"
        };
    }

    public string GetRandomPrompt()
    {
        string randomPrompt = "";

        int randomIndex = new Random().Next(prompts.Count);

        randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
}