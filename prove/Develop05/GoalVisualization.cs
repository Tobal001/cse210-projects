
class GoalVisualizationActivity : Activity
{
    public GoalVisualizationActivity(string name, string description) : base(name, description) { }

    public void Run()
    {
        Console.WriteLine("\nTake a deep breath, close your eyes, and imagine a goal you want to achieve.");
        Thread.Sleep(2000);

        Console.WriteLine("What is the goal you’re working toward? (Press Enter when you’re ready to describe it.)");
        Console.Write("Goal: ");
        string goal = Console.ReadLine();

        Console.WriteLine("\nNow, imagine yourself successfully achieving this goal. How does it feel?");
        Thread.Sleep(2000);
        Console.WriteLine("Write a few words describing the feeling: ");
        string feeling = Console.ReadLine();

        Console.WriteLine("\nWhat are some steps or actions you can take to reach this goal?");
        string steps = Console.ReadLine();

        Console.WriteLine("\nThank you for sharing! Here’s a summary of your visualization:");
        Console.WriteLine($"- Goal: {goal}");
        Console.WriteLine($"- Feeling: {feeling}");
        Console.WriteLine($"- Steps: {steps}");
    }
}