using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        string LetterGrade = "";
        string failOrPass = "";

        Console.WriteLine("What is your grade in percentage(%)");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        
    
        // Number grade to letter grade
        if (grade >= 90)
        {
            LetterGrade = "A";
        }
        else if (grade >= 80)
        {
            LetterGrade = "B";
        }
        else if (grade >= 70)
        {
            LetterGrade = "C";
        }
        else if (grade >= 60)
        {
            LetterGrade = "D";
        }
        else
        {
            LetterGrade = "F";
        }

        //Did you pass or fail the Course?
         if (grade >=70)
        {
            failOrPass = "Congrats! You Passed course!"; 
        }
        else 
        {
            failOrPass = "Sorry, you failed the course.";
        }
        
        Console.WriteLine($"Your letter grade is: {LetterGrade}. {failOrPass}");

    }
}