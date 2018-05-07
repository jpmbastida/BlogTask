using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Entities.Contents
{
    public class KindOfContents
    {
        [Key]
        public int KindOfContentsId { get; set; }
        public bool Tech { get; set; }
        public bool Science { get; set; }
        public bool World { get; set; }
        public bool Economics { get; set; }
        public bool Fashion { get; set; }
        public bool Spectacles { get; set; }
    }
}