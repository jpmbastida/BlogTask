using Blog.Entities.Contents;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entities.Polls
{
    /// <summary>
    /// Usage: 
    /// This class <c>Polls</c> implements the polls data model.
    /// </summary>
    public class Polls
    {
        [Key]
        public int PollId { get; set; }
        public bool Genre { get; set; }
        public int Age { get; set; }
        [ForeignKey(nameof(MusicGenres))]
        public int MusicGenresId { get; set; }
        [ForeignKey(nameof(Content))]
        public int KindOfContentsId { get; set; }
        public string Proposals { get; set; }

        public virtual MusicGenres MusicGenres { get; set; }
        public virtual KindOfContents Content { get; set; }
    }
}