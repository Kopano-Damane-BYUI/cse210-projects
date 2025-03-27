// Program.cs
using System;
using System.Collections.Generic;

namespace YouTubeVideoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Video class
            Video video1 = new Video("How to Program in C#", "John Doe", 120);
            Video video2 = new Video("Learn C# in 30 Minutes", "Jane Smith", 180);
            Video video3 = new Video("Advanced C# Programming", "Alice Brown", 300);

            // Create and add comments to video1
            video1.AddComment(new Comment("User1", "Great video! Really helpful."));
            video1.AddComment(new Comment("User2", "I learned a lot, thank you!"));
            video1.AddComment(new Comment("User3", "Very clear explanations."));

            // Create and add comments to video2
            video2.AddComment(new Comment("User4", "This was very quick, I understood the basics."));
            video2.AddComment(new Comment("User5", "Great summary of the topic!"));

            // Create and add comments to video3
            video3.AddComment(new Comment("User6", "This is an in-depth tutorial."));
            video3.AddComment(new Comment("User7", "I am already familiar with most of this, but great for beginners."));
            video3.AddComment(new Comment("User8", "Excellent content, would love to see more advanced topics."));

            // Create a list of videos and add the videos
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Iterate through the list of videos and display their details
            foreach (var video in videos)
            {
                video.DisplayVideoDetails(); // Display details for each video
            }
        }
    }
}