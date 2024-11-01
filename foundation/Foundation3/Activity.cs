public abstract class Activity
{
    protected string _date;
    protected string _activityName;
    protected double _activityLength;
    

    public Activity(string date, string activityName, int activityLenght)
    {
        _date = date;
        _activityName = activityName;
        _activityLength = activityLenght;
    }

    public abstract double Distance();
    public virtual double Speed()
    {
        return (Distance()/_activityLength) * 60;
    }
    public virtual double Pace()
    {
        return _activityLength / Distance();
    }

    public virtual string GetSummery()
    {
        return $"{_date} {_activityName} ({_activityLength} Min)- Distance {Distance():F2} Km, Speed: {Speed():F2} Kph, Pace {Pace():F2} min per Km";
    }



    



}
