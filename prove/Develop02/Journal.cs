using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text.Json;


// !! Exceeded requirements: Save and load document as a JSON file !!
public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {   
        Entry newEntry = new Entry(); 

        PromptGenerator newPromt = new PromptGenerator();
        newEntry._promptText = newPromt.GetRandomPrompt();
        Console. WriteLine("");
        Console.WriteLine(newEntry._promptText);

        Console.Write("> ");
        newEntry._Text = Console.ReadLine();
        Console.WriteLine("");

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

//Serialized file to Json format 
    public void SaveToFile()
    {   
        
        Console.Write("Save File As (Please including .json): ");
        string fileName = Console.ReadLine();

        string jsonString = JsonSerializer.Serialize(_entries);

        File.WriteAllText(fileName, jsonString);

        Console.WriteLine($"Entries saved to file: {fileName}\n");
    }

//Desearlized JSON file, to allow the entries into _entries 
    public void LoadFromFile() 
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();
        
        if (File.Exists(fileName))
        {
            _entries.Clear();

            string jsonString = File.ReadAllText(fileName);

            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);

            Console.WriteLine("File loaded successfully.\n");
        }
        else
        {
            Console.WriteLine("file not found.");
        }

    }
}