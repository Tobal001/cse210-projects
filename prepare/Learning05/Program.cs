using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assignment = new Assignment("Cristobal Henriquez", "Fiction Writing");
        Console.WriteLine(Assignment.GetSummary());

        MathAssignment Math = new MathAssignment("Cristobal H", "Calculus", "20-100", "A-Z");
        Console.WriteLine(Math.GetHomeworkList());

        WritingAssignment Write = new WritingAssignment("Cristobal H", "fiction", "The Dog That Went Woof");
        Console.WriteLine(Write.GetWritingInformation());

    }
}