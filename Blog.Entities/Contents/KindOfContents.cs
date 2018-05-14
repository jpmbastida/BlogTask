using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Contents
{
    /// <summary>
    /// Usage: 
    /// This class <c>KindOfContents</c> implements the types of contents data model for Polls.
    /// </summary>
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