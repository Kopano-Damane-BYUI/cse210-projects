// Comment.cs
using System;

namespace YouTubeVideoProgram
{
    // Class to represent a Comment on a video
    public class Comment
    {
        public string Commenter { get; set; }  // Name of the person who made the comment
        public string Text { get; set; }       // Text of the comment

        // Constructor to initialize Comment object with commenter's name and comment text
        public Comment(string commenter, string text)
        {
            Commenter = commenter;
            Text = text;
        }
    }
}
