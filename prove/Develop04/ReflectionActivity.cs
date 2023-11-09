using System.Runtime.CompilerServices;

public class ReflectionActivity : Activity
{
    private List<string> promptListReflect = new List<string> {"Think of a time when you felt confident", "Think of a time when you served someone", "Think of a time when you did something difficult"};

    public string RandomPrompt()
    {
        Random rand = new Random();
        int promptNumber = rand.Next(1, promptListReflect.Count);
        string randomPrompt = promptListReflect[promptNumber];
        return randomPrompt;
    }


}