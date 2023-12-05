using System;
using System.Xml.Linq;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        MenuChoice choice = new MenuChoice();
        bool running = true;
        while (running)
        {
            Console.WriteLine("-Menu Options-");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goal");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit program");
            Console.Write("Your selection >");

            string menuInput = Console.ReadLine();
            int menuNumber = int.Parse(menuInput);

            if (menuNumber == 1)
            {
                choice.CreateGoal();
            }
            if (menuNumber == 2)
            {
                choice.ListGoalsDetails();
            }
            if (menuNumber == 3)
            {
                choice.SaveGoals();
            }
            if (menuNumber == 4)
            {
                choice.LoadGoals();
            }
            if (menuNumber == 5)
            {
                choice.RecordEvent();
            }
            if (menuNumber == 6)
            {
                running = false;
            }
        }
    }
}