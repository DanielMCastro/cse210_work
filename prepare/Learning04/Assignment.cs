

public class Assignment
{
    public string studentName {get; set;}
    public string sectionName {get; set;}

    public void Assignment1(string student, string topic)
    {
        studentName = student;
        sectionName = topic;
    }

    public string GetAssignment()
    {
        return studentName + " - " + sectionName;
    }
    public string GetStudentName()
    {
        return studentName;
    }
}