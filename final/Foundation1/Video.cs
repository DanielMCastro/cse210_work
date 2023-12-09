public class Video
{
    private string title;
    private string author;
    private float length;
    public List<Comment> comments = new List<Comment>();
    
    public Video(string videoTitle, string videoAuthor, float videoLength)
    {
        title = videoTitle;
        author = videoAuthor;
        length = videoLength;
    }

    public string GetVideoDetails()
    {
        return $"Title: {title} - Author: {author} - Length: {length}";
    }
    public void GetVideoComments()
    {
        foreach(Comment comment in comments)
        {
            comment.GetComment();
        }
    }
}