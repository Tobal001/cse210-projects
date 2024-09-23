using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int numSquared = SquareNumber(userNumber);

        DisplayResult(userName, numSquared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber= int.Parse(Console.ReadLine());
        
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int numSquared = userNumber * userNumber;
        return numSquared;     
    }

    static void DisplayResult(string userName, int numSquared)
    {
        Console.WriteLine($"{userName}, the sqaure of your number is {numSquared}");  
    }
}