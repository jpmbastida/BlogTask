using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Entities.Contents;

namespace Blog.Entities.Polls.ViewModels
{
    public class PollItem
    {
        public int Id { get; set; }
        public bool Genre { get; set; }
        public int Age { get; set; }
        public MusicGenres MusicGenres { get; set; }
        public KindOfContents Content { get; set; }
        public string Proposals { get; set; }
    }
}