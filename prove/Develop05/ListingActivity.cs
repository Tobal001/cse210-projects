using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
    {
       _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("You may begin in: ");
         

        int responseCount = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
        Console.Write("> ");
        Console.ReadLine();
        responseCount++;
        }

        Console.WriteLine($"You listed {responseCount} items!");

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        return $"--- {randomPrompt} ---";
    }
}