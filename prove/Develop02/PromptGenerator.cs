using System;
public class PromptGenerator 
{
    public List<string> _prompts = new List<string>
        {
            "What are three things I’m grateful for today, and why?",
            "What is a recent challenge I’ve faced, and how did I handle it?",
            "Describe a moment where I felt truly at peace. What contributed to that feeling?",
            "What are my top three priorities in life right now?",
            "If I could spend a day doing anything I wanted, what would it look like?",
            "Write about a person who has had a positive impact on my life.",
            "How do I typically respond to stress, and what are healthier ways I could cope?",
            "What is one habit I want to cultivate, and what steps can I take to start?",
            "Reflect on a recent conversation that left a lasting impression on me.",
            "Where do I see myself five years from now, and how can I start working towards that vision today?",
            "What is one thing I wish others knew about me but have never shared?",
            "Describe my perfect morning routine. What would it include?",
            "What is a value or principle I hold dear, and how do I live it out daily?",
            "Write about a time when I took a risk. What did I learn from that experience?",
            "How do I define success, and how does that align with my current lifestyle?",
            "What do I love most about my current stage in life?",
            "Reflect on a meaningful experience I had during my childhood.",
            "How do I handle criticism, and how can I improve in accepting constructive feedback?",
            "What is one dream or goal I’ve set aside, and how can I reignite my passion for it?",
            "Who inspires me, and what qualities do I admire in them?",
            "What role does faith or spirituality play in my life right now?",
            "Write about a book, movie, or podcast that recently resonated with me and why.",
            "If I could write a letter to my younger self, what would I say?",
            "What do I need to forgive myself for?",
            "What are three things I can do to show more kindness to others this week?"
        };
    



    public string GetRandomPrompt()
    {   
        Random random = new Random();
        int promt = random.Next(_prompts.Count);
        string newPrompt =_prompts[promt];

        return newPrompt;
        
    }
}