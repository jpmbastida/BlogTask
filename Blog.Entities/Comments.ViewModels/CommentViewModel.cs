using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Comments.ViewModels
{
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