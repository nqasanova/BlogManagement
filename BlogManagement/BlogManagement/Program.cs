using System;
using System.Collections.Generic;

namespace BlogManagement
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Blog
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string[] HashTags { get; set; }
        public BlogStatus Status { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public Blog(string title, string content, BlogStatus status, params string[] hashTags)
        {
            Title = title;
            Content = content;
            Status = status;
            HashTags = hashTags;
        }
    }

    public enum BlogStatus
    {
        Created = 1,
        Approved = 2,
        Canceled = 3
    }
}
