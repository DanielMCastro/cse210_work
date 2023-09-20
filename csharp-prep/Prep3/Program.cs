using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);
        */

        Random numberGenerator = new Random();
        int magicNumber = numberGenerator.Next(1, 11);

        Console.Write("What is your guess for the magic number? ");
        string guess = Console.ReadLine();
        int numberGuess = int.Parse(guess);
        int guessTally = 0;

        while (magicNumber != numberGuess)
        {
            if (magicNumber > numberGuess)
            {
                Console.Write("Guess higher! Try again: ");
                guess = Console.ReadLine();
                numberGuess = int.Parse(guess);
                guessTally ++;
            }
            else if (magicNumber < numberGuess)
            {
                Console.Write("Guess lower! Try again: ");
                guess = Console.ReadLine();
                numberGuess = int.Parse(guess);
                guessTally ++;
            }
        }
        if (magicNumber == numberGuess)
        {
            Console.WriteLine($"You guessed it! It took you {guessTally} guesses");
        }
        

    }
}