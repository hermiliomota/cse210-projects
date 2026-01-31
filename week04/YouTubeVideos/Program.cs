using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Wonders of Space", "Alice", 300);
        Video video2 = new Video("Cooking 101", "Bob", 600);
        Video video3 = new Video("C# Programming Basics", "Charlie", 450);

        video1.AddComment(new Comment("João", "Amazing video!"));
        video1.AddComment(new Comment("Ricardo", "Loved the visuals."));
        video1.AddComment(new Comment("Luís", "Great explanation!"));

        video2.AddComment(new Comment("Charles", "Very helpful."));
        video2.AddComment(new Comment("Ethan", "I tried this recipe, it works!"));
        video2.AddComment(new Comment("Paula", "Yummy!"));

        video3.AddComment(new Comment("Jorge", "Very clear explanation."));
        video3.AddComment(new Comment("Hannah", "Helpful for beginners."));
        video3.AddComment(new Comment("Helton", "Thanks for sharing!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"\t{comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); 
        }
    }
}
