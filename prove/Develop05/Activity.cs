using System.ComponentModel;
using System.Xml;

public class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Wealcome to the {_name}\n");
        Console.WriteLine($"This activity will help you {_description}");
        Console.WriteLine();
        Console.Write($"How long in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
    }

   public void ShowLoading(int seconds)
    {
         int milliseconds = seconds * 1000;
        int interval = 500;

        for (int i = 0; i < milliseconds / interval; i++)
            {   
                Console.Write("\r.   "); 
                Thread.Sleep(interval);

                Console.Write("\r..  ");  
                Thread.Sleep(interval);

                Console.Write("\r... "); 
                Thread.Sleep(interval); 
            }
            Console.Clear();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); 
        }
    }
}
