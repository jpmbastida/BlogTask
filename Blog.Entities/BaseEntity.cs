﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime Time { get; set; }
    }
}
