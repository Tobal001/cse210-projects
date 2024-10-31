public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, string points): base (name, description, points)
    {
    }

    public override void RecordEvent()
    {
        if (IsComplete() == true)
        {
            Console.WriteLine($"Great job completing {_shortName}!");
            Console.WriteLine($"You gain {_points} points");

        }
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({_description})";
    }
}