using System;
using System.ComponentModel;

public class Reference
{
    private string book;
    private int chapter;
    public int verse;
    public int endVerse;

    public string Reference1(int oneVerse, int lastVerse)
    {
        string reference = $"{book} {chapter}:{oneVerse}-{lastVerse}";
        return reference;
    }

    public void ReferenceSet(string userBook, int userChapter, int userVerse, int userEndVerse)
    {
        book = userBook;
        chapter = userChapter;
        verse = userVerse;
        endVerse = userEndVerse;
    }

    public string ReferenceGet()
    {
        string reference = Reference1(verse, endVerse);
        return reference;
    }
}