using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("test event", "it's an event", "tomorrow", "3:00AM", "my house", "me", 462);
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.ShortDescription(lecture));

        Reception reception = new Reception("another one", "it's a reception this time", "yesterday", "11:36PM", "BYUI", "hotmail@gmail.com");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.ShortDescription(lecture));

        Outdoor outdoor = new Outdoor("the final show", "it'll be nice", "when you're ready", "17:83", "mother nature's home", "the best you've seen");
        Console.WriteLine(outdoor.FullDetails());
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.ShortDescription(lecture));
    }
}