using System;
using System.ComponentModel;
using System.ComponentModel.Design;


// Creativity and Exceeding Requirements: Added another Activity, "Goal Visualizer," which guides the user through a three-step visualization exercise.
// This activity prompts the user to think about a personal goal, outline practical steps  toward reaching the goal. 
 // Enhancement: Animated the breathing activity to simulate real breathing
class Program
{
    static void Main(string[] args)
    {
        string menuOptions = "";

        do
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listening activity\n4. Goal visualization activity\n 5. Quit");
            Console.Write("Select a Choice from the menu: ");

            try 
            {        
                menuOptions = Console.ReadLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (menuOptions)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.ShowLoading(3);
                    breathingActivity.Run();
                    breathingActivity.ShowLoading(3);
                    breathingActivity.DisplayEndingMessage();
                    breathingActivity.ShowLoading(3);
                break; 
                
                case "2":

                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflection Activity","reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.ShowLoading(1);
                    reflectingActivity.Run();
                    reflectingActivity.ShowLoading(1);
                    reflectingActivity.DisplayEndingMessage();
                    reflectingActivity.ShowLoading(1);
                break;

                   case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing Activity","reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.DisplayStartingMessage();
                    listingActivity.ShowLoading(1);
                    listingActivity.Run();
                    listingActivity.ShowLoading(1);
                    listingActivity.DisplayEndingMessage();
                    listingActivity.ShowLoading(1); 
                    break;

                    case "4":
                    GoalVisualizationActivity goalActivity = new GoalVisualizationActivity("Goal Visualization Activity", "Visualize a personal goal, imagine yourself achieving it, and consider the steps needed to reach it.");
                    goalActivity.DisplayStartingMessage();
                    goalActivity.ShowLoading(1);
                    goalActivity.Run();
                    goalActivity.ShowLoading(1);
                    goalActivity.DisplayEndingMessage();
                    goalActivity.ShowLoading(1);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
        

            }

        } while(menuOptions != "5");

    }
}