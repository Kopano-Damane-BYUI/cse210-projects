// Video.cs
using System;
using System.Collections.Generic;

namespace YouTubeVideoProgram
{
    // Class to represent a Video
    public class Video
    {
        public string Title { get; set; }         // Title of the video
        public string Author { get; set; }        // Author of the video
        public int LengthInSeconds { get; set; }  // Length of the video in seconds
        public List<Comment> Comments { get; set; } // List of comments for the video

        // Constructor to initialize a Video object with title, author, and length
        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            Comments = new List<Comment>(); // Initialize an empty list for comments
        }

        // Method to return the number of comments for this video
        public int GetNumberOfComments()
        {
            return Comments.Count; // Return the count of comments in the list
        }

        // Method to add a new comment to the video
        public void AddComment(Comment comment)
        {
            Comments.Add(comment); // Add the comment to the list
        }

        // Method to display details of the video, including comments
        public void DisplayVideoDetails()
        {
            Console.WriteLine($"Title: {Title}"); // Display the video title
            Console.WriteLine($"Author: {Author}"); // Display the video author
            Console.WriteLine($"Length: {LengthInSeconds} seconds"); // Display video length in seconds
            Console.WriteLine($"Number of Comments: {GetNumberOfComments()}"); // Display the number of comments

            // Loop through and display each comment for this video
            foreach (var comment in Comments)
            {
                Console.WriteLine($"Comment by {comment.Commenter}: {comment.Text}"); // Display each comment with its author
            }

            Console.WriteLine(); // Add a blank line for readability
        }
    }
}
