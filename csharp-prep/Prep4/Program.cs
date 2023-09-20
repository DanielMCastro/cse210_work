using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        Console.WriteLine("Enter numbers, and enter \"0\" when finished.");
        int newNumber = 1;
        int listSum = 0;
        int maxNumber = 0;
        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            newNumber = int.Parse(userNumber);
            numbersList.Add(newNumber);
        }
        foreach (int number in numbersList)
        {
            listSum = listSum + number;
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        int listAverage = listSum / (numbersList.Count - 1);
        Console.WriteLine($"The sum of your list is {listSum}");
        Console.WriteLine($"The average of your list is {listAverage}");
        Console.WriteLine($"The largest number in your list is {maxNumber}");
    }
}