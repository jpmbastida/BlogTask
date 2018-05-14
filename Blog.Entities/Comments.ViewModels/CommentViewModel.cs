using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Comments.ViewModels
{
    /// <inheritdoc />
    /// <summary>
    /// Usage: 
    /// This class <c>PollViewModel</c> implements the poll data model for the View with validation for <see cref="P:Blog.Entities.Comments.ViewModels.CommentViewModel.Comment" />.
    /// </summary>
    public class CommentViewModel : IValidatableObject
    {
        public int CommentId { get; set; }
        public string Author { get; set; }
        public DateTime Time { get; set; }
        public string Comment { get; set; }

        public List<CommentItem> AllComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Comment))
            {
                yield return new ValidationResult("Comment must not be empty, please write your comments.");
            }
        }
    }
}