using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entities.Comments
{
    public class Comment : BaseEntity
    {
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "Comment")]
        public string CommentBody { get; set; }
    }
}