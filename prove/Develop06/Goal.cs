public abstract class Goal 
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public int Points => int.TryParse(_points, out int parsedPoints) ? parsedPoints : 0;
    public string ShortName => _shortName;
    public string Description => _description;

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return "No additional details for this goal";
    }
    public abstract string GetStringRepresentation();
    
}