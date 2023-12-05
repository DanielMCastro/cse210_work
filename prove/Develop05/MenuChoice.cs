public class MenuChoice
{
    private List<Goals> goals = new List<Goals>();
    private int goalPoints;

    public MenuChoice()
    {
        goals = new List<Goals>();
        goalPoints = 0;
    }
    public void CreateGoal()
    {
        Console.WriteLine("What type of goal do you want?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Checklist goal");
        Console.WriteLine("3. Eternal goal");
        Console.Write("Your selection >");


        string typeInput = Console.ReadLine();
        int goalType = int.Parse(typeInput);

        Console.WriteLine("The name of your goal >");
        string name = Console.ReadLine();
        Console.WriteLine("Description of your goal >");
        string description = Console.ReadLine();
        Console.WriteLine("Points awarded for completing you goal >");
        string pointsInput = Console.ReadLine();
        int points = int.Parse(pointsInput);

        if (goalType == 1)
        {
            SimpleGoals simpleGoal = new SimpleGoals(name, description, points);
            goals.Add(simpleGoal);
        }
        if (goalType == 2)
        {
            Console.WriteLine("How many times will you repeat the goal before it is completed? >");
            int goalRepetitions = int.Parse(Console.ReadLine());
            Console.WriteLine("And how many bonus points will be awarded upon goal completion? >");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoals checklistGoal = new ChecklistGoals(name, description, bonusPoints, goalRepetitions, bonusPoints);
            goals.Add(checklistGoal);
        }
        if (goalType == 3)
        {
            EternalGoals eternalGoal = new EternalGoals(name, description, points);
            goals.Add(eternalGoal);
        }
    }
    public void ListGoalsDetails() 
    {
        int count = 1;

        Console.WriteLine("Your goals: ");

        foreach (Goals goal in goals) 
            {
                Console.WriteLine($"{count}. {goal.CompletedDescription()}");
                count++;
            }

        Console.WriteLine($"You have {goalPoints} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string goalFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(goalFile)) 
        {
            outputFile.WriteLine(goalPoints);
            foreach (Goals goal in goals)
            {
                outputFile.WriteLine(goal.GetGoalDetails());
            }
        }
        Console.WriteLine("The goals have been saved!");
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal life? ");
        string loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFile);

        goalPoints = int.Parse(lines.First());

        string[] text = lines.Skip(1).ToArray();
        
        foreach(string line in text)
        {    
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string details = parts[1];
            string[] part = details.Split(",");

            if (goalType == "SimpleGoal")
            {
                SimpleGoals simpleLoads = new SimpleGoals(part[0], part[1], int.Parse(part[2]));

                goals.Add(simpleLoads);
                
            } else if (goalType == "EternalGoal")
            {
                EternalGoals eternalLoads = new EternalGoals(part[0], part[1], int.Parse(part[2]));
                    
                goals.Add(eternalLoads);

            } else if (goalType == "ChecklistGoal")
            {
                ChecklistGoals checklistLoads = new ChecklistGoals(part[0], part[1], int.Parse(part[2]), int.Parse(part[4]), int.Parse(part[3]));
                checklistLoads.SetAmount(int.Parse(part[5]));

                goals.Add(checklistLoads);
            }

        }
        Console.WriteLine($"You have {goalPoints} right now. "); 
    }
    public void RecordEvent()
    {
        ListGoalsDetails();
        Console.WriteLine("Which goal did you accomplish?");
        int goalCompleted = int.Parse(Console.ReadLine());

        goals[goalCompleted - 1].RecordEvent();

        int totalPoints = goals[goalCompleted - 1].GetGoalPoints();

        goalPoints += totalPoints;

        Console.WriteLine($"You have earned {totalPoints} points.");

        Console.WriteLine($"You have {goalPoints} points!");
    }
}