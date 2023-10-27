using System;

public class Words
{
    public string verseWord {get; set;}

    public string HideOrShow (string word)
    {
        //Random random = new Random();
        //int number = random.Next(1, word.Length);
        Hide(word);
        return word;
    }

    public string Hide(string word)
    {
        string blankWord = "";
        foreach (char c in word)
        {
            char letter = c;
            letter = '_';
            blankWord += "_";
        }
        return blankWord;
    }
}