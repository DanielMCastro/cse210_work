using System.Dynamic;

public abstract class Goals
{
    private string name;
    private string description;
    private int completionPoints;

    public Goals(string goalName, string goalDescription, int goalCompletionPoints)
    {
        name = goalName;
        description = goalDescription;
        completionPoints = goalCompletionPoints;
    }
    public string GetGoalName()
    {
        return name;
    }
    public string GetGoalDescription()
    {
        return description;
    }
    public int GetGoalPoints()
    {
        return completionPoints;
    }
    public void SetGoalPoints(int points)
    {
        completionPoints = points;
    }
    public abstract void RecordEvent();

    public abstract bool CompletionStatus();

    public abstract string GetGoalDetails();

    public virtual string CompletedDescription()
    {
        if (CompletionStatus())
        {
            return $"*Completed goal* {name} {description}";
        }
        else
        {
            return $"*Incompleted goal* {name} {description}" ;
        }
    }  
}