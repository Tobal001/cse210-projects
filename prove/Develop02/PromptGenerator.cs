using System;
public class PromptGenerator 
{
    public List<string> _prompts = new List<string>
        {
            "What is one thing that made me smile today?",
        "How do I feel about the progress I’ve made this week?",
        "What is one goal I want to achieve this month?",
        "How did I overcome a recent challenge?",
        "What is my favorite place to relax?",
        "Who is someone I admire and why?",
        "What is my favorite way to spend a day off?",
        "What is one thing I learned recently?",
        "What is the most memorable part of my day?",
        "How do I stay motivated when things get tough?",
        "What is one book that has influenced me?",
        "What is something I am looking forward to?",
        "How do I define success in my life?",
        "What is a new habit I want to develop?",
        "How do I like to celebrate small victories?",
        "What does my ideal day look like?",
        "How do I find peace in difficult situations?",
        "What is something I enjoy doing for myself?",
        "What is one personal value that guides my actions?",
        "How do I prioritize my time when I am busy?"
        };
    



    public string GetRandomPrompt()
    {   
        Random random = new Random();
        int promt = random.Next(_prompts.Count);
        string newPrompt =_prompts[promt];

        return newPrompt;
        
    }
}