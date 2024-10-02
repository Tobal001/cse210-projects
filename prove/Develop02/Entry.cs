public class Entry 
{
    public string _date {get; set;}
    public string _promptText {get; set;}
    public string _Text {get; set;}

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}\nPrompt: {_promptText}\n{_Text}\n");
    }
}