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
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {   
                
                theJournal.AddEntry();
            }   
            else if (menu == 2)
            {
                theJournal.DisplayAll();
            }
            else if (menu == 3)
            {
                theJournal.LoadFromFile();
            }
            else if ( menu == 4)
            {
                theJournal.SaveToFile();
            }
            else 
            {
                Console.WriteLine("Sorry, please try again.");
            }
        }while (menu != 5);        
        
    }
}