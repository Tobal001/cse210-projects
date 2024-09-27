using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job(); //Instantiation: Creating a new instance (object) of the 'Job' class using the 'new' keyword.
        job1._company = "Apple"; // Assignment: Setting the '_company' field of the 'job1' instance to "Apple".
        job1._jobTitle =  "Manager";
        job1._startYear = 2022;
        job1._endYear = 2023;

        //Another Job instance
        Job job2 = new Job();
        job2._company ="Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2019;
        job2._endYear = 2022;
        
        Resume resume1 = new Resume();
        resume1._name = "Cristobal Henriquez";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);    

        resume1.ResumeDetails();
    
    }

}