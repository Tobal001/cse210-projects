public class BreathingActivity : Activity 
{
    public BreathingActivity(string name, string description) 
        :base(name, description)
    {
    }

    public void Run()
    {  
        int totalDuration = _duration;
        int cycleDuration = 2 * (10 * 100 + 500);
        int maxBreathSize = 10;

        while (totalDuration > 0)
        {
           
            for (int space = 0; space <= maxBreathSize; space++)
            {   
                Console.Clear();
                Console.WriteLine(new string("Breath in\n") + new string(' ', space) + "o" + new string(' ', space));
                Thread.Sleep(100);
            }

            Thread.Sleep(500);

            for (int space = maxBreathSize; space >= 0; space--)
            {
                Console.Clear();
                Console.WriteLine(new string("Breath out\n") + new string(' ', space) + "O" + new string(' ', space));
                Thread.Sleep(100);
            }

            Thread.Sleep(500);
            totalDuration -= cycleDuration / 1000;
            
        }

        Console.WriteLine("Breathing exercise complete!");

    }
}