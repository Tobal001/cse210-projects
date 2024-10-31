public class ChecklistGoal: Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus): base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress recorded for {_shortName}. Current Progress: {_amountCompleted}/{_target}");
        
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You've completed {_shortName} and earned a bonus of {_bonus} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    
    public int Bonus => _bonus;
    public int Target => _target;
    public int AmountCompleted
    {
        get => _amountCompleted;
        set => _amountCompleted = value;
    }
    public override string GetDetailsString()
    {
       return $"{_shortName}: {_description} - Progress: {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        if (IsComplete() == false)
        {
            return $"[ ] {_shortName} ({_description}) - [{_amountCompleted}/{_target}]";
        }
        else
        {
            return $"[x] {_shortName} ({_description}) - [{_amountCompleted}/{_target}]";
        }

    }

}




