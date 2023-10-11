using System.IO;
using System.Runtime.CompilerServices;

public class Journal
{
    public string fileName;
    public List<Journal> journalEntries {get; set;}

    public void SaveJournal(List<string> entries)
    {
        Console.WriteLine("What is the name of the new file? ");
        string journalName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(journalName))
        {
            foreach (string item in entries)
            {
                outputFile.WriteLine(item);
            }
        }
    }
    public void LoadJournal()
    {
        Console.WriteLine("What is the name of the file? ");
        string journalName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(journalName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}