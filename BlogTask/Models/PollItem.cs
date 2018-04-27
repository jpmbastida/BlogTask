using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogTask.Controllers;
using BlogTask.Models;

namespace BlogTask.Models
{
    public class PollItem
    {
        public bool Genre { get; set; }
        public int Age { get; set; }
        public MusicGenres MusicGenres { get; set; }
        public KindOfContents Content { get; set; }
        public string Proposals { get; set; }
    }
}