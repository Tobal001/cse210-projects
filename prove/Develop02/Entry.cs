public class Entry 
{
    public string _date;
    public string _promptText;
    public string _Text;

    public void Display()
    {
        Console.WriteLine($"{_date}\n{_promptText}\n{_Text}\n");
    }
}