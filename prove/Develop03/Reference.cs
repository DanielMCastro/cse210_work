using System;
using System.ComponentModel;

public class Reference
{
    public string book {get; set;}
    public int chapter {get; set;}
    public int verse {get; set;}
    public int endVerse {get; set;}

    /*public void Reference1(int oneVerse)
    {
        Console.Write($"{book} {chapter}:{oneVerse}");
    }*/
    public string Reference1(int oneVerse, int lastVerse)
    {
        string reference = $"{book} {chapter}:{oneVerse}-{lastVerse}";
        return reference;
    }

    public void ReferenceSet(string userBook, int userChapter, int userVerse, int userEndVerse)
    {
        userBook = book;
        userChapter = chapter;
        userVerse = verse;
        userEndVerse = endVerse;
    }

    public string ReferenceGet()
    {
        string reference = Reference1(verse, endVerse);
        return reference;
    }
}