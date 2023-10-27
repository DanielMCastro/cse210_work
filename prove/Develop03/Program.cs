using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        {
            scripture.scriptures  = new List<string>();
        }
        Reference reference = new Reference();
        Words word = new Words();

        reference.ReferenceSet("Philippians", 4, 13, 0);

        // getting ready for user input, printing the scripture and reference
        string referenceScripture = $"{reference.ReferenceGet()}" + " I can do all things through Christ which strengheneth me.";
        scripture.scriptures.Add(referenceScripture);
        Console.WriteLine("Press the \"enter\" key to clear some words, or type quit if you are finished.");
        Console.WriteLine("");
        Console.WriteLine(scripture.scriptures[0]);

        //taking user input to clear words or quit program
        string userInput = Console.ReadLine();
        while (userInput != "quit")
        {
            string newVerse = "";
            int i = 0;

            Console.Clear();
            foreach (string verseWord in scripture.scriptures[i].Split())
            {
                i += 1;
                Random rand = new Random();
                int number = rand.Next(1, 5);
                if (number == 1)
                {  
                    string blankWord = word.Hide(verseWord);
                    newVerse += blankWord;
                }
                else
                {
                newVerse = newVerse + " " + verseWord;
                }
            }
            Console.WriteLine(newVerse);
            Console.ReadLine();
            if (userInput == "quit")
            {
                Console.WriteLine("Good job memorizing the scripture!");
            }
        }
        
    } 
}
