using System;
using System.IO;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {   
        Entry newEntry = new Entry(); 

        PromptGenerator newPromt = new PromptGenerator();
        newEntry._promptText = newPromt.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);

        Console.Write("> ");
        newEntry._Text = Console.ReadLine();

        DateTime theCurrenTime = DateTime.Now;
        newEntry._date = theCurrenTime.ToShortDateString();
        
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
     
    }

    public void SaveToFile()
    {
        Console.Write("Save File As: ");
        string file = Console.ReadLine();
        
        

    }

    public void LoadFromFile() 
    {
        Console.Write("Enter file name: ");
        string loadFile = Console.ReadLine();
        
        if (File.Exists(loadFile))
        {
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(loadFile);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry 
                    {
                        _date = parts[0].Trim(),
                        _promptText = parts[1].Trim(),
                        _Text = parts[2].Trim()
                    };
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("file not found.");
        }

    }
}