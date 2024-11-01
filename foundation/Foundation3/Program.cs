using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        string date = today.ToString("dd MMM yyyy");
        
        List<string> activityList = new List<string>();

        StationaryBicycle statBike = new StationaryBicycle(date, "Stationary Bicycle", 40, 10);
        activityList.Add(statBike.GetSummery());

        SwimmingPool swim = new SwimmingPool(date, "Swimming", 20, 8);
        activityList.Add(swim.GetSummery());

        Running run = new Running(date, "Running", 50, 10.5);
        activityList.Add(run.GetSummery());

        foreach (string activity in activityList)
        {
            Console.WriteLine(activity);
        }

    }
}