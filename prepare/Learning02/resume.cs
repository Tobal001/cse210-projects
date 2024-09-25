public class Resume {    // Class Declaration
    public string _name;   // Field Declaration
    public List<Job> _jobs = new List<Job>();  // Field Declaration & Initialization

    public void ResumeDetails()     // Method Declaration
    {
        Console.WriteLine($"Name: {_name}");    // Method Calls
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails(); // Method Call:
        }

    }

}