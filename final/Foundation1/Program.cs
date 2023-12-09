using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("I Give Up", "The Royal Foundry", 180);
        Comment comment1v1 = new Comment("james123", "What a great song!!!");
        video1.comments.Add(comment1v1);
        Comment comment2v1 = new Comment("jonnyboi", "This goes hard");
        video1.comments.Add(comment2v1);
        Comment comment3v1 = new Comment("XxAmazingNinjaxX", "Wish I could be there");
        video1.comments.Add(comment3v1);
        videos.Add(video1);

        Video video2 = new Video("NPC DND Episode 3", "Viva La Dirt League", 1200);
        Comment comment1v2 = new Comment("Baradun", "These guys are great");
        video2.comments.Add(comment1v2);
        Comment comment2v2 = new Comment("Bodger", "I'm sick of garlic and potatoes");
        video2.comments.Add(comment2v2);
        Comment comment3v2 = new Comment("Bob", "I'm going to jump inside of him!!");
        video2.comments.Add(comment3v2);
        videos.Add(video2);

        Video video3 = new Video("Light The World", "Church of Jesus Christ", 540);
        Comment comment1v3 = new Comment("matthew374", "Remember why we have Christmas!");
        video3.comments.Add(comment1v3);
        Comment comment2v3 = new Comment("Jonas67", "These always help me make the Christmas season better");
        video3.comments.Add(comment2v3);
        Comment comment3v3 = new Comment("ritp93", "I'm always excited for this");
        video3.comments.Add(comment3v3);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine(video.GetVideoDetails());
            video.GetVideoComments();
        }
    }
}