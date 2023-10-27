using System;
public class Writing : Assignment
{
    public string paperTitle {get; set;}

    public void Writing1(string title)
    {
        paperTitle = title;
    }

    public string GetWritingInformation()
    {
        string homework = base.studentName;
        homework += $"{paperTitle} by {homework}";
        return homework;
    }
}