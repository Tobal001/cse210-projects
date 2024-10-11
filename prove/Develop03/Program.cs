using System;
using System.Security.Cryptography;

// Exeeded Requirement: When user types 'hint' the first letters of the hidden words will be shown, type 'hint' again to turn off.
class Program
{
    static void Main(string[] args)
    {
        Referance referance = new Referance("Alma", 7, 11, 11);
        
        Scripture scripture = new Scripture(referance, "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.");
        
        bool showHint = false;
        Console.WriteLine("\n\n");
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("");
        Console.Write("Please enter to continue or type 'quit to finish:");
        string userInput = Console.ReadLine();
        while (userInput != "quit")
        {
            if (userInput == "hint")
            {
                showHint = !showHint;
                Console.WriteLine($"Hint mode {(showHint ? "ON" : "OFF")}");
            }
            else
            {
            scripture.HideRandomWords(2);
            }

            Console.WriteLine(scripture.GetDisplayText(showHint));

            Console.WriteLine("");
            Console.Write("Please press enter to continue or type 'quit' to finish. enter 'hint', to turn hint on and off: ");
            userInput = Console.ReadLine();
            Console.Clear();

            if (scripture.IsCompletelyHidden())
            {
                Environment.Exit(0);
            }

        }
    
    }
}
