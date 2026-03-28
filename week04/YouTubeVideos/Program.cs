using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Videos part
        Video video1 = new Video("C# Basics Tutorial", "CodeMaster", 600);
        Video video2 = new Video("Top 10 Programming Tips", "DevWorld", 480);
        Video video3 = new Video("Programming if i'd start all over again", "LearnFast", 720);
        Video video4 = new Video("Debugging Like a Pro", "TechGuru", 540);

        //comments part 1-4
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I finally understand this topic."));

        video2.AddComment(new Comment("Dave", "Awesome tips!"));
        video2.AddComment(new Comment("Eve", "Tip #3 was my favorite."));
        video2.AddComment(new Comment("Frank", "Straight to the point and even has timestamps!"));

        video3.AddComment(new Comment("Grace", "This is the kinda content we need more of"));
        video3.AddComment(new Comment("Heidi", "Clear and concise."));
        video3.AddComment(new Comment("Thierry", "Can you make more like this?"));

        video4.AddComment(new Comment("Elisabete", "Debugging finally makes sense."));
        video4.AddComment(new Comment("Karl", "Saved me hours of frustration."));
        video4.AddComment(new Comment("Leo", "Excellent walkthrough."));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}

//no additional features