using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entities.Comments
{
    /// <summary>
    /// Usage: 
    /// This class <c>Comment</c> implements the comment data model.
    /// </summary>
    public class Comment : BaseEntity
    {
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Comment")]
        public string CommentBody { get; set; }
    }
}