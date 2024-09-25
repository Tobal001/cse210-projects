
//New Job Class
//Public: The access modifier public means the fields can be accessed from outside the class.
    //This means any instance of Job can have its fields read or modified directly.
public class Job {  // Class Declaration: Defining the class named 'Job', which is a blueprint for creating objects representing a job.
    
    //Member variables (or attributes)
    // The C# convention is to start member variable with and underscore_
    public string _company; //// Field Declaration: A public field '_company' of type 'string' that will store the company name.
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Member function (Method)
    //Uses the data from the member variables(above)
    public void DisplayJobDetails() // Method Declaration: Defining a public method named 'DisplayJobDetails' that does not return a value (void).
    {
     Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");  
     // Method Call: This calls the 'Console.WriteLine' method to print a formatted string to the console.
    // String Interpolation: The syntax $"{...}"
    }
}