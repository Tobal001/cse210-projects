using System.Net.NetworkInformation;

public class StationaryBicycle: Activity
{
    public int _speed;

    public StationaryBicycle( string date, string activityName, int activityLenght, int speed): base(date, activityName, activityLenght)
    {
        _speed = speed;

    }

    public override double Distance()
    {
       return _speed * _activityLength / 60.0;
    }

    public override double Speed()
    {
        return _speed;
    }
}