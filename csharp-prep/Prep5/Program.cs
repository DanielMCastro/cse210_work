using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the prgoram!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name here: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number here: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int numberSquared = userNumber * userNumber;
        return numberSquared;
    }

    static void DisplayResult(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
    }

}