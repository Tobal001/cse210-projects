public class Running: Activity
{
    private double _distance;

    public Running(string date, string activityName, int activityLenght, double distance): base(date, activityName, activityLenght)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

}