using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
// Creating videos
Video video1 = new Video("Machine Learning Basics", "AI Academy", 900);
Video video2 = new Video("Data Structures Explained", "GeekForGeeks", 780);
Video video3 = new Video("JavaScript Essentials", "Frontend Mastery", 860);

// Adding comments
video1.AddComment(new Comment("Sophia", "Amazing breakdown of concepts!"));
video1.AddComment(new Comment("Liam", "Very informative, thank you!"));
video1.AddComment(new Comment("Olivia", "Please make a part 2!"));

video2.AddComment(new Comment("Noah", "Finally, I understand linked lists!"));
video2.AddComment(new Comment("Emma", "Great examples, very helpful."));
video2.AddComment(new Comment("Mason", "Would love a deep dive into trees!"));

video3.AddComment(new Comment("Ava", "This clarified so much for me!"));
video3.AddComment(new Comment("James", "Really well explained, appreciate it."));
video3.AddComment(new Comment("Isabella", "Keep up the great work!"));

// Storing videos in a list
List<Video> videos = new List<Video> { video1, video2, video3 };

// Displaying video information
foreach (var video in videos)
{
    video.DisplayVideoInfo();
        }
    }
    
    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; }
        private List<Comment> comments = new List<Comment>();
    
        public Video(string title, string author, int duration)
        {
            Title = title;
            Author = author;
            Duration = duration;
        }
    
        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }
    
        public void DisplayVideoInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Duration: {Duration} seconds");
            Console.WriteLine("Comments:");
            foreach (var comment in comments)
            {
                Console.WriteLine($"- {comment.Author}: {comment.Text}");
            }
        }
    }
    
    class Comment
    {
        public string Author { get; set; }
        public string Text { get; set; }
    
        public Comment(string author, string text)
        {
            Author = author;
            Text = text;
        }
    }

    }
