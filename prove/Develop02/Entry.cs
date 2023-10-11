public class Entry
{
    public string prompt;
    public string date;
    public string response;

    public void AddEntry()
    {
        
    }
    public void DisplayEntries()
    {

    }
    public string DisplayPrompts()
    {
        string fullEntry = $"Date: {date} -- Prompt: {prompt} -- {response}";
        return fullEntry;
    }
}