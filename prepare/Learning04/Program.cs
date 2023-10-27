using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assignment1 = new Assignment();
        {
            Assignment1.studentName = "Jon";
            Assignment1.sectionName = "American History";
        }
        Math Math1 = new Math();
        {
            Math1.bookPage = "275";
            Math1.problemSet = "8-15";
        }
        Writing Writing1 = new Writing();
        {
            Writing1.paperTitle = "The American Civil War";
        }
        Console.WriteLine(Assignment1.GetAssignment());
        //Console.WriteLine(Math1.GetHomework());
        Console.WriteLine(Writing1.GetWritingInformation());
    }
}