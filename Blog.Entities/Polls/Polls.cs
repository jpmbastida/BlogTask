using Blog.Entities.Contents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Entities.Polls
{
    public class Polls
    {
        [Key]
        public int PollId { get; set; }
        public bool Genre { get; set; }
        public int Age { get; set; }
        [ForeignKey("MusicGenres")]
        public int MusicGenresId { get; set; }
        [ForeignKey("Content")]
        public int KindOfContentsId { get; set; }
        public string Proposals { get; set; }

        public virtual MusicGenres MusicGenres { get; set; }
        public virtual KindOfContents Content { get; set; }
    }
}