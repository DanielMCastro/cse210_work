public class Activity
{
    private int duration;
    private string activity;
    private string description;

    public string StartMessage()
    {
        return($"This is the {activity} activity. It's purpose is to {description}. How long would you like this activity to last?");
    }

    public string endMessage() //fix this! it needs to be void, and just print stuff out.
    {
        return($"Good job on the mindfulness exercise!You have just completed the {activity} activity, and did it for {duration} seconds.");
    }
    
    public void DisplayAnimation()
    {
        
        Console.Write("_");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("o");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("O");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("*");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("*");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("O");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("o");
        Thread.Sleep(250);  
        Console.Write("\b \b");
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("_");
        Thread.Sleep(250);
        Console.Write("\b \b");  
    }

    public void PauseTimer(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write("\b \b");
            Console.Write(seconds);
            seconds--;
        }
    }
}