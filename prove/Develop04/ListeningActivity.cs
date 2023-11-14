public class ListeningActivity : Activity
{
    private List<string> promptListListen = new List<string>{"Who in your life are you greatful for?", "What are some of your strengths?", "What have you achomplished this week?", "What are upcoming events you are excited for?"};

    public ListeningActivity(int activityDuration, string activityActivity, string activityDescription) : base(activityDuration, activityActivity, activityDescription)
    {

    }
    public void RandomPrompt()
    {
        Random rand = new Random();
        int promptNumber = rand.Next(1, promptListListen.Count);
        string randomPrompt = promptListListen[promptNumber];
        Console.WriteLine(randomPrompt);
    }
}