using System;

class Program
{
    static string displayMenu()
    {
        Console.WriteLine("Please choose an option from the menu: ");
        Console.WriteLine("1. Reflection Activity");
        Console.WriteLine("2. Breathing Activity");
        Console.WriteLine("3. Listening Activity");
        Console.WriteLine("4. Quit");
        Console.Write("> ");
        string menuChoice = Console.ReadLine();
        return menuChoice;
    }
    static void Main(string[] args)
    {
        Activity activity = new Activity();

        string menuChoice = displayMenu();

        while (menuChoice != "4")
        {
            if (menuChoice == "1")
            {
                Console.Write("How long (in seconds) do you want the activity to last? ");
                string inputSeconds = Console.ReadLine();
                int seconds = int.Parse(inputSeconds);
                ReflectionActivity reflectionActivity = new ReflectionActivity(seconds, "reflection", "This activity will guide you in thinking of times of strength in your life.");
                activity.DisplayAnimation(2);
                Console.WriteLine("Consider the following prompt, and press enter when ready to continue:");
                reflectionActivity.RandomPrompt();
                Console.ReadLine();
                DateTime startTime = DateTime.Now;
                DateTime finishTime = startTime.AddSeconds(seconds);
                DateTime currentTime = DateTime.Now;
                while (currentTime < finishTime)
                {
                    currentTime = DateTime.Now;
                    reflectionActivity.RandomPrompt2();
                    Console.ReadLine();
                    activity.DisplayAnimation(2);
                }
                activity.EndMessage();
                activity.DisplayAnimation(8);
                menuChoice = displayMenu();

            }
            if (menuChoice == "2")
            {
                Console.Write("How long (in seconds) do you want the activity to last? ");
                string inputSeconds = Console.ReadLine();
                int seconds = int.Parse(inputSeconds);
                BreathingActivity breathingActivity = new BreathingActivity(seconds, "breathing", "This activity will guide you through a simple breathing exercise.");
                activity.DisplayAnimation(2);
                Console.WriteLine("Ok, press enter when ready to begin");
                Console.ReadLine();
                DateTime startTime = DateTime.Now;
                DateTime finishTime = startTime.AddSeconds(seconds);
                DateTime currentTime = DateTime.Now;
                while (currentTime < finishTime)
                {
                    currentTime = DateTime.Now;
                    breathingActivity.BreathEvent(seconds);
                }
                activity.EndMessage();
                activity.DisplayAnimation(8);
                menuChoice = displayMenu();
            }
            if (menuChoice == "3")
            {
                Console.Write("How long (in seconds) do you want the activity to last? ");
                string inputSeconds = Console.ReadLine();
                int seconds = int.Parse(inputSeconds);
                ListeningActivity listeningActivity = new ListeningActivity(seconds, "listening", "This activity will help you recognize the good things in your life.");
                activity.DisplayAnimation(2);
                Console.WriteLine("You have 8 seconds to reflect on the prompt below before the timer starts.");
                listeningActivity.RandomPrompt();
                activity.DisplayAnimation(8);
                DateTime startTime = DateTime.Now;
                DateTime finishTime = startTime.AddSeconds(seconds);
                DateTime currentTime = DateTime.Now;
                int greatfulLevel = 0;
                while (currentTime < finishTime)
                {
                    greatfulLevel ++;
                    currentTime = DateTime.Now;
                    Console.ReadLine();
                }
                activity.EndMessage();
                Console.WriteLine($"You listed {greatfulLevel} items!");
                activity.DisplayAnimation(8);
                menuChoice = displayMenu();
            }
        }
        Console.WriteLine("Thank you for using this program, shutting down...");
    }
}