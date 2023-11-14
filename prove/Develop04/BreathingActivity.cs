using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(int activityDuration, string activityActivity, string activityDescription) : base(activityDuration, activityActivity, activityDescription)
    {

    }

    public void BreathEvent(int seconds)
    {
        int breathSeconds = seconds / 8;
        for (int s = 0; s < breathSeconds; s++)
        {
            Console.Clear();
            Console.WriteLine("[Breath in....1]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[Breath in....2]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[Breath in....3]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[Breath in....4]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[Breath out...1]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[Breath out...2]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[Breath out...3]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[Breath out...4]");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}