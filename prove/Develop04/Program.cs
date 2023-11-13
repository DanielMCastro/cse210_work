using System;

class Program
{
    static void Main(string[] args)
    {
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
                Activity activity = new Activity();
                Console.Write("How long do you want the activity to last?");
                string seconds = Console.ReadLine();
                ReflectionActivity reflectionActivity = new ReflectionActivity(int.Parse(seconds), "reflection", "This activity will guide you in thinking of times of strength in your life.");
                activity.DisplayAnimation(3);
                Console.WriteLine("Consider the following prompt, and press enter when ready to continue:");
                reflectionActivity.RandomPrompt();
                Console.ReadLine();
                DateTime startTime = DateTime.Now;
                DateTime finishTime = startTime.AddSeconds(int.Parse(seconds));
                while (startTime < finishTime)
                {
                    reflectionActivity.RandomPrompt2();
                    Console.ReadLine();
                    activity.DisplayAnimation(3);
                }
                activity.EndMessage();

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