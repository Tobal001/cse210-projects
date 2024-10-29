using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity( string name, string description) 
        : base(name, description)
    {
         _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        
         _questions = new List<string>
        {
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
    }    

    public void Run()
    {
        Console.WriteLine("Conisder the following prompt: ");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have somthing in mind, press enter to continue.");
        Console.ReadLine();
        ShowLoading(3);

        Console.WriteLine();

        Console.WriteLine("Now ponder each of the following questions related to this experience:");
    

            int totalDuration = 0;
            while (totalDuration < _duration)
            {   
                
                    DisplayQuestions();
                    ShowLoading(5);
                    totalDuration += 5;
            

            }

            DisplayEndingMessage(); 
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;

    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];

        return randomQuestion;

    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}   
