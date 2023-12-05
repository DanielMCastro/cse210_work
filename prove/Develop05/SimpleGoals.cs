class SimpleGoals : Goals
{
    private bool goalStatus;

    public SimpleGoals(string name, string description, int points) : base(name, description, points)
    {
        goalStatus = false;
    }

    public override void RecordEvent()
    {
        goalStatus = true;
    }
    public override bool CompletionStatus()
    {
        return goalStatus;
    }
    public override string GetGoalDetails()
    {
        return $"SimpleGoal:{base.GetGoalName()},{base.GetGoalDescription()},{base.GetGoalPoints()},{goalStatus}";
        //return goalDescription;
    }
}