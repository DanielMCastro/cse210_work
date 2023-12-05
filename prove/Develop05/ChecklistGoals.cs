class ChecklistGoals : Goals
{
    private int taskRepetitions;
    private int targetRepetitions;
    private int bonusPoints;

    public ChecklistGoals(string name, string description, int points, int repetitions,  int bonus) : base(name, description, points)
    {
        targetRepetitions = repetitions;
        bonusPoints = bonus;
        taskRepetitions = 0;
    }

    public override void RecordEvent()
    {
        taskRepetitions ++;

        if (targetRepetitions == taskRepetitions)
        {
            int totalPoints = GetGoalPoints() + bonusPoints;
            SetGoalPoints(totalPoints);
        }
    }

    public override bool CompletionStatus()
    {
        if (taskRepetitions == targetRepetitions)
        {  
            return true;
        }
        else
        {
        return false;
        }
    }
    public override string GetGoalDetails()
    {
        string checklistDescription = $"ChecklistGoal:{base.GetGoalName()},{base.GetGoalDescription()},{base.GetGoalPoints()},{bonusPoints},{targetRepetitions},{taskRepetitions}";

        return checklistDescription;
    }

    public override string CompletedDescription()
    {
        return ($"{base.CompletedDescription()} -- Currently completed: {taskRepetitions}/{targetRepetitions}");
    }

    public void SetAmount(int tasks)
    {
        taskRepetitions = tasks;
    }
}