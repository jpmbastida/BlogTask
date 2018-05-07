using System;

namespace Blog.Entities.Comments.ViewModels
{
    public class CommentItem
    {
        public string Comment { get; set; }
        public string Author { get; set; }
        public DateTime Time { get; set; }
    }
}