using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Contents
{
    /// <summary>
    /// Usage: 
    /// This class <c>MusicGenres</c> implements the types of music data model for Polls.
    /// </summary>
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