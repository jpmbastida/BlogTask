using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Entities.Contents
{
    public class MusicGenres
    {
        [Key]
        public int MusicGenresId { get; set; }
        public bool House { get; set; }
        public bool Country { get; set; }
        public bool Rock { get; set; }
        public bool Pop { get; set; }
        public bool Classic { get; set; }
        public bool Ethnic { get; set; }
        public bool Rap { get; set; }
    }
}