using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
    
        Console.WriteLine("Enter a list of numbers, type 0 when finished."); 
        
    
        int newNumber = -1;
        while (newNumber != 0)
        {    
            Console.Write("Enter number: ");

            newNumber = int.Parse(Console.ReadLine());
                
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        //Step 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The Sum total: {sum}");
        
        //Part 2: Compute the average 
        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        //Part 3: Find the Max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"the max is: {max}");
    }




}