using System;
using System.Collections.Generic;

namespace BlogTask.Models
{
    public static class Comment
    {
        public static List<CommentItem> listComments = new List<CommentItem>
        {
            new CommentItem
            {
                Author = "John Wick",
                Comment = "So nice site bro!!!",
                Time = new DateTime(2018, 05, 14)
            },

            new CommentItem
            {
            Author = "Peter Parker",
            Comment = "Great job!!!",
            Time = new DateTime(2018, 01, 22)
        }
};

        static object _objLock = new Object();

        public static void AddComment(CommentItem comment)
        {
            if (string.IsNullOrWhiteSpace(comment.Author))
            {
                comment.Author = "Anonymous";
            }
            comment.Time = DateTime.Now;

            lock (_objLock)
            {
                listComments.Add(comment);
            }
        }
    }
}