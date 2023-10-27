using System;
using System.Threading.Tasks.Dataflow;
public class Math : Assignment
{
    
    public string bookPage {get; set;}
    public string problemSet {get; set;}
    public void Math1(string book, string problem)
    {
        bookPage = book;
        problemSet = problem;
    }
    public string GetHomework()
    {
        //why does this next line work?? it should only retrieve "studentName" but it seems to call GetAssignment, as it includes "- {sectionName}"
        string homework = base.studentName;
        homework += $" Section - {bookPage} Problems - {problemSet}";
        return homework;
    }
}

