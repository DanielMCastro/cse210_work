using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percent for the class?");
        string answer = Console.ReadLine();
        int gradePercent = int.Parse(answer);
        string letter = "";
        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else if (gradePercent < 60)
        {
            letter = "F";  
        }

        Console.WriteLine($"Your letter grade is: {letter}");
        if (letter == "D" || letter == "F")
        {
            Console.WriteLine("I'm sorry, you did not pass the class. Try again!");
        }
        else
        {
            Console.WriteLine("You passed the class. Congratulations!");
        }
    }
}