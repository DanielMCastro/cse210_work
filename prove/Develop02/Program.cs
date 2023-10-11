using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.IO;
using System.IO.Enumeration;

class Program
{
    //Creating the menu
    public static void menu()
    {
        Console.WriteLine();
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Write an entry");
        Console.WriteLine("2. Display entries");
        Console.WriteLine("3. Save the journal");
        Console.WriteLine("4. Load a saved journal");
        Console.WriteLine("5. Quit");
        Console.Write(">");
    }
    static void Main(string[] args)
    {
        //variables to be used
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        //Random rand = new Random();
        //int randomPrompt = rand.Next(0, 4);
        List<string> prompts = new List<string>();
        prompts.Add("How did you see the hand of God in your life today?");
        prompts.Add("What is something that you are greatful for today?");
        prompts.Add("What are you proud of that you did today?");
        prompts.Add("How do you plan to be better tomorrow?");
        prompts.Add("How did you serve someone today?");
        List<string> entries = new List<string>();

        Entry entry = new Entry();
        {
            dateText = theCurrentTime.ToShortDateString();

            //entry.prompt = prompts[randomPrompt];
            entry.date = dateText;
            entry.response = "";
        }

        Journal journal = new Journal();
        {
            journal.fileName = "";
        }

        //Starting user input
        menu();
        string userSelection = Console.ReadLine();

        while (userSelection != "5")
        {
            if (userSelection == "1")
            {
                Random rand = new Random();
                int randomPrompt = rand.Next(0, 4);
                Console.WriteLine();
                Console.WriteLine(prompts[randomPrompt]);
                Console.Write(">");
                entry.response = Console.ReadLine();

                entries.Add(entry.DisplayPrompts());
                menu();
                userSelection = Console.ReadLine();
            }

            if (userSelection == "2")
            {
                Console.WriteLine();
                foreach (string item in entries)
                {
                    Console.WriteLine(item);
                }
                menu();
                userSelection = Console.ReadLine();
            }

            if (userSelection == "3")
            {
                journal.SaveJournal(entries);

                menu();
                userSelection = Console.ReadLine();

            }

            if (userSelection == "4")
            {
                journal.LoadJournal();

                menu();
                userSelection = Console.ReadLine();
            }
            
        }
        if (userSelection == "5")
        {
            Console.WriteLine("Shutting down...");
        }
    }
}