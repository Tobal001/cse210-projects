using System.ComponentModel.Design;
using System.Reflection.Metadata;

public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {   
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {      
        string menu = "";
        
        do
        {
        Console.WriteLine($"You have {_score} points.\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
        Console.Write("Select a choice from the menu: ");
        
        try
        {
            menu = Console.ReadLine();  
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }

        switch (menu)
        {
            case "1":
                CreateGoal();
            break;

            case "2":
                ListGoalNames();
            break;

            case "3":
                SaveGoals();
            break;

            case "4":
                LoadGoals();
            break;

            case"5":
                RecordEvent();
            break;

            case "6":
                Console.WriteLine("Exiting the program");
            break;

            default:
                Console.WriteLine("Invalid input. Please enter a number from the menu.");
            break;
        }


        } while (menu != "6");

    
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()} ");
        }
        Console.WriteLine();
    }
    
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }

        Console.WriteLine();

    }
    
    public void CreateGoal()
    {
            string menu = "";

            while (menu != "1" && menu != "2" && menu != "3")
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("  1. simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                Console.Write("What kind of Goal would you like to create? "); 

                menu = Console.ReadLine();

                if (menu != "1" && menu != "2" && menu != "3")
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                }
            }

            Console.Write("What is the the name of your Goal? ");
            string goalName = Console.ReadLine();

            Console.Write("Write a short description of your goal? ");
            string goalDescription = Console.ReadLine();

            Console.Write("Please assign an amount of points to this goal: ");
            string goalPoints = Console.ReadLine();

            if (!int.TryParse(goalPoints, out _))
            {
                Console.WriteLine("Invalid input. Points must be a number.");
                return; // Exit if the input is not a valid number
            }


            switch (menu)
            {   
                //SIMPLE GOALS
                case "1":
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(simpleGoal);
                    Console.WriteLine("Simple Goal created and added.");

                    break;

                case "2":
                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(eternalGoal);
                    Console.WriteLine("Eternal Goal created and added.");
                    break;

                case "3":
                    Console.Write("How many times does this goal need to be accomplished?");
                    int target;
                    while (!int.TryParse(Console.ReadLine(), out target))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for the target.");
                    }

                    Console.Write("How many bonus point will you achive, once all are complete? ");
                    int bonus;
                    while (!int.TryParse(Console.ReadLine(), out bonus))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for the bonus.");
                    }

                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
                    _goals.Add(checklistGoal);
                    Console.WriteLine("Checklist goal created and added.");
                    break;
            }
        
    }

public void CelebrateGoalCompletion(string goalName)
    {
        string message = $"Congratulations! You have achieved the goal: {goalName}!";
        AnimateFlyingStar();
        AnimateText(message);
    }

    private void AnimateFlyingStar()
    {
        int consoleWidth = Console.WindowWidth;
        int consoleHeight = Console.WindowHeight;

       
        int startX = 0;
        int startY = consoleHeight / 2; 

      
        for (int x = startX; x < consoleWidth; x++)
        {
            Console.Clear(); 
            Console.SetCursorPosition(x, startY);
            Console.Write("*");
            Thread.Sleep(50); 
        }
        
        Console.Clear();
    }

    private void AnimateText(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50); 
        }
        Console.WriteLine();
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record progress: ");
        ListGoalNames();

        int goalIndex;
        Console.Write("Enter the goal number: ");
        if (int.TryParse(Console.ReadLine(), out goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            bool wasComplete = selectedGoal.IsComplete();

           
            selectedGoal.RecordEvent();

          
            if (!wasComplete && selectedGoal.IsComplete())
            {
                _score += selectedGoal.Points;
                if (selectedGoal is ChecklistGoal checklistGoal)
                {
                    _score += checklistGoal.Bonus;
                }

                CelebrateGoalCompletion(selectedGoal.ShortName);
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    
    public void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(_score);

                foreach (Goal goal in _goals)
                {
                    string goalType = goal.GetType().Name;
                    string goalData = $"{goalType}|{goal.ShortName}|{goal.Description}|{goal.Points}";

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        goalData += $"|{checklistGoal.Target}|{checklistGoal.Bonus}|{checklistGoal.AmountCompleted}";
                    }

                    writer.WriteLine(goalData);
                }
            }
            Console.WriteLine("Goals successfully saved!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }


    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved data found.");
            return;
        }

        _goals.Clear();

        try
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    
                    if (parts.Length < 4)
                    {
                        Console.WriteLine("Error: Malformed data line. Skipping.");
                        continue;
                    }

                    string goalType = parts[0].Trim();
                    string name = parts[1].Trim();
                    string description = parts[2].Trim();
                    string points = parts[3].Trim();

                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        _goals.Add(simpleGoal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);
                    }
                    else if (goalType == "ChecklistGoal" && parts.Length == 7)
                    {
                        int target = int.Parse(parts[4].Trim());
                        int bonus = int.Parse(parts[5].Trim());
                        int amountCompleted = int.Parse(parts[6].Trim());

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus)
                        {
                            AmountCompleted = amountCompleted
                        };
                        _goals.Add(checklistGoal);
                    }
                    else
                    {
                        Console.WriteLine("Error: Unknown goal type or malformed data. Skipping.");
                    }
                }
            }
            Console.WriteLine("Goals successfully loaded!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
        }
    }
}