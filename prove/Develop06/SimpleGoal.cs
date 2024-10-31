public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points): base (name, description, points)
    {
        _isComplete = false;
    }

    public override string GetStringRepresentation()
    {
        return _isComplete ? $"[x] {_shortName} ({_description})" : $"[ ] {_shortName} ({_description})";
    }

    public override bool IsComplete()
    {   
        return _isComplete;
    
    }
    public override void RecordEvent()
    {   
        if (!_isComplete)
        {
            Console.WriteLine($"Great job completing {_shortName}!");
            _isComplete = true;
        }

        else 
        {
            Console.WriteLine($"{_shortName} has already been completed.");
        }

    }

}