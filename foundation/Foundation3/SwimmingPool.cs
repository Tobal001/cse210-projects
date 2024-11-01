public class SwimmingPool: Activity
{
    private int _numberOfLaps;

    public SwimmingPool(string date, string activityName, int activityLenght, int numberOfLaps): base(date, activityName, activityLenght)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double Distance()
    {
       return _numberOfLaps * 50 / 1000.0; 
    }
}