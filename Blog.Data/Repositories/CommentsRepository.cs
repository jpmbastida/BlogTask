using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Data.Context;
using Blog.Entities.Comments;
using Blog.Entities.Comments.ViewModels;

namespace Blog.Data.Repositories
{
    /// <summary>
    /// Usage: 
    /// Implements the Repository for Comments.
    /// This repository includes methods <see cref="GetAll()"/> and <see cref="SaveComment(CommentViewModel)"/> for obtaining all Polls and Adding a new Poll.
    /// </summary>
    public class CommentsRepository
    {
        /// <summary>
        /// Usage: 
        /// Method for obtaining all Polls.
        /// <see cref="GetAll()"/> 
        /// </summary>
        /// <returns>CommenViecModel.</returns>
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

        /// <summary>
        /// Usage: 
        /// Method for saving a Comment.
        /// <see cref="SaveComment(CommentViewModel)"/> 
        /// </summary>
        /// <returns>A bool.</returns>
        /// <param name="vComment">The Comment model from view.</param>
        public bool SaveComment(CommentViewModel vComment)
        {
            if (vComment == null) return false;
            using (var contex = new BlogContext())
            {
                var comment = new Comment()
                {
                    Author = vComment.Author ?? "Anonymous",
                    Time = DateTime.Now,
                    CommentBody = vComment.Comment
                };
                contex.Comments.Add(comment);
                contex.SaveChanges();
                return true;
            }
        }
    }
}
