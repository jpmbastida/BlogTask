using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.PublicPolls
{
    public class PublicPoll
    {
        [Key]
        public int Id { get; set; }
        public int Tech { get; set; }
        public int Science { get; set; }
        public int Fashion { get; set; }
        public int Photography { get; set; }
        public int Weather { get; set; }
    }
}
