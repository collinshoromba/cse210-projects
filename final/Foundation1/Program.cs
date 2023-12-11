using System;

class Program
{
    static void Main(string[] args)
    {
         // Creating videos and adding comments
        Video video1 = new Video { Title = "Introduction to C#", Author = "CSharp Dev", LengthSeconds = 300 };
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot.");

        Video video2 = new Video { Title = "Web Development Basics", Author = "CodeMaster", LengthSeconds = 450 };
        video2.AddComment("User3", "Very informative.");
        video2.AddComment("User4", "Can you make more tutorials on CSS?");

        Video video3 = new Video { Title = "Data Science in 10 Minutes", Author = "DataGeek", LengthSeconds = 600 };
        video3.AddComment("User5", "Awesome content!");
        video3.AddComment("User6", "Could you explain machine learning briefly?");

        Video video4 = new Video { Title = "Cooking with Chef John", Author = "ChefJohn", LengthSeconds = 480 };
        video4.AddComment("User7", "This recipe changed my life!");
        video4.AddComment("User8", "I tried it, and it's delicious.");

        // Putting videos in a list
        List<Video> videosList = new List<Video> { video1, video2, video3, video4 };

        // Displaying video information
        foreach (Video video in videosList)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumComments()}");

            if (video.GetNumComments() > 0)
            {
                Console.WriteLine("Comments:");
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
                }
            }

            Console.WriteLine("\n");
        }
    }
}