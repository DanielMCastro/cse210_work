using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        Run run = new Run("Nov 21", 10, 3);
        Bike bike = new Bike("Dec 25", 30, 16);
        Swim swim = new Swim("June 14", 15, 37);
        exercises.Add(run);
        exercises.Add(bike);
        exercises.Add(swim);
        
        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}