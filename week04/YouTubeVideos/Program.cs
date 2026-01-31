using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics Tutorial", "Code Academy", 600);
        video1.AddComment(new Comment("João", "Great explanation!"));
        video1.AddComment(new Comment("Ricardo", "Very helpful, thanks."));
        video1.AddComment(new Comment("Luís", "Clear and easy to follow."));
        videos.Add(video1);

        Video video2 = new Video("Understanding Abstraction", "Dev Simplified", 480);
        video2.AddComment(new Comment("Charles", "This finally makes sense."));
        video2.AddComment(new Comment("Ethan", "Awesome examples."));
        video2.AddComment(new Comment("Paula", "Exactly what I needed."));
        videos.Add(video2);

        Video video3 = new Video("Object-Oriented Programming Explained", "Tech World", 720);
        video3.AddComment(new Comment("Jorge", "Nice overview."));
        video3.AddComment(new Comment("Hannah", "Loved the visuals."));
        video3.AddComment(new Comment("Helton", "Very informative."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length (seconds): " + video.GetLength());
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}
