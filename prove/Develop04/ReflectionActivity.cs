using System.Runtime.CompilerServices;

public class ReflectionActivity : Activity
{
    private List<string> promptListReflect = new List<string> {"Think of a time when you felt confident", "Think of a time when you served someone", "Think of a time when you did something difficult"};
    private List<string> promptList2 = new List<string> {"How did it make you feel?", "What prompted you to do that?", "What was your favorite part?", "What can you learn from this?"};

    public void RandomPrompt()
    {
        Random rand = new Random();
        int promptNumber = rand.Next(1, promptListReflect.Count);
        string randomPrompt = promptListReflect[promptNumber];
        Console.WriteLine(randomPrompt);
    }
    public void RandomPrompt2()
    {
        Random rand = new Random();
        int promptNumber = rand.Next(1, promptList2.Count);
        string randomPrompt = promptList2[promptNumber];
        Console.WriteLine(randomPrompt);
    }
    public void receiveAnswer()
    {
        Console.Write(">");
        Console.ReadLine();
    }
        public ReflectionActivity(int activityDuration, string activityActivity, string activityDescription) : base(activityDuration, activityActivity, activityDescription)
    {

    }
}