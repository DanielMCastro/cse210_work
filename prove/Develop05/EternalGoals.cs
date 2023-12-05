public class EternalGoals : Goals
{
    public EternalGoals(string name, string description, int points) : base(name, description, points){}

    public override void RecordEvent()
    {
        CompletionStatus(); 
    }

    public override bool CompletionStatus()
    {
        return false;
    }

    public override string GetGoalDetails()
    {
        return $"Eternal Goal:{base.GetGoalName()},{base.GetGoalDescription()},{base.GetGoalPoints()}";
    }
}