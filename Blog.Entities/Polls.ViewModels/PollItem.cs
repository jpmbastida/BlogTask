using Blog.Entities.Contents;

namespace Blog.Entities.Polls.ViewModels
{
    /// <summary>
    /// Usage: 
    /// This class <c>PollItem</c> implements the poll item data model for the View.
    /// </summary>
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