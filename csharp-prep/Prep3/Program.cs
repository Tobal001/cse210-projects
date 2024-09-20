using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        
        int randomNumber = randomGenerator.Next(1,10); 
        Console.WriteLine($"What is the magic number? {randomNumber}");
       
        int guess = -1;
        int guessCount = 1;

        while (guess != randomNumber)
        {   
            guessCount++;
            Console.Write("What is your number?");  
            guess = int.Parse(Console.ReadLine());

            if (randomNumber > guess)
            {
                Console.WriteLine("Guess higher");
            }
            else if (randomNumber < guess)
                {
                    Console.WriteLine("Guess lower");
                }

            else 
            {
                Console.WriteLine($"You guessed it, you guessed {guessCount} times");
            }

        }

    }
}