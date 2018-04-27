using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogTask.Models
{
    public class ViewCommentModel : IValidatableObject
    {
        public List<CommentItem> AllComments { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Comment))
            {
                yield return new ValidationResult("Comment must not be empty, please write your comments.");
            }
        }
    }
}