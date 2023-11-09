using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();

        ReflectionActivity reflectionActivity = new ReflectionActivity();

        ListeningActivity listeningActivity = new ListeningActivity();

        Console.WriteLine("Please choose an option from the menu: ");
        Console.WriteLine("1. Reflection Activity");
        Console.WriteLine("2. Breathing Activity");
        Console.WriteLine("3. Listening Activity");
        Console.WriteLine("4. Quit");
        Console.Write("> ");
        string menuChoice = Console.ReadLine();

        while (menuChoice != "4")
        {
            if (menuChoice == "1")
            {

            }
            if (menuChoice == "2")
            {

            }
            if (menuChoice == "3")
            {

            }
        }
    }
}