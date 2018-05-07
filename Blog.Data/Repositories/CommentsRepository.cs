using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Data.Context;
using Blog.Entities.Comments;
using Blog.Entities.Comments.ViewModels;

namespace Blog.Data.Repositories
{
    public class CommentsRepository
    {
        public CommentViewModel GetAll()
        {
            using (var context = new BlogContext())
            {
                CommentViewModel commentsToDisplay = new CommentViewModel();
                List<Comment> comments = new List<Comment>();
                comments = context.Comments.ToList();

                if (comments != null)
                {
                    List<CommentItem> allComments = new List<CommentItem>();
                    foreach (var comment in comments)
                    {
                        allComments.Add(
                            new CommentItem()
                            {
                                Author = comment.Author,
                                Time = comment.Time,
                                Comment = comment.CommentBody
                            }
                        );
                    }
                    commentsToDisplay.AllComments = allComments;
                    return commentsToDisplay;
                }
            }
            return null;
        }

        public bool SaveComment(CommentViewModel vCommment)
        {
            if (vCommment == null) return false;
            using (var contex = new BlogContext())
            {
                var comment = new Comment()
                {
                    Author = vCommment.Author ?? "Anonymous",
                    Time = DateTime.Now,
                    CommentBody = vCommment.Comment
                };
                contex.Comments.Add(comment);
                contex.SaveChanges();
                return true;
            }
        }
    }
}
