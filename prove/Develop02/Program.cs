using System;
using System.ComponentModel.Design;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   

        Journal theJournal = new Journal();

        int menu = 0;
        do
        {   
            
            Console.WriteLine("Please select one of the following Choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            
            try 
            {
                menu = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }   

            switch (menu)
            {
                case 1:
                    theJournal.AddEntry();
                    break;
                case 2:
                    theJournal.DisplayAll();
                    break;
                case 3:
                    theJournal.LoadFromFile();
                    break;
                case 4:
                theJournal.SaveToFile();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    break;
            }

            Console.WriteLine("");
            
        }while (menu != 5);        
        
    }
}