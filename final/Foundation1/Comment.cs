public class Comment
{
    private string name;
    private string comment;

    public Comment(string userName, string userComment)
    {
        name = userName;
        comment = userComment;
    }

    public void GetComment()
    {
        Console.WriteLine($"User {name}: {comment}");
    }
}