using System;

namespace Blog.Entities.Comments.ViewModels
{
    /// <summary>
    /// Usage: 
    /// This class <c>CommentItem</c> implements the comment item data model for the View.
    /// </summary>
    public class CommentItem
    {
        public string Comment { get; set; }
        public string Author { get; set; }
        public DateTime Time { get; set; }
    }
}