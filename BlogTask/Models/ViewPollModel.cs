using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogTask.Models
{
    public class ViewPollModel : IValidatableObject
    {
        public List<PollItem> PollItems { get; set; }
        public bool Genre { get; set; }
        public int Age { get; set; }
        public MusicGenres MusicGenres { get; set; }
        public KindOfContents Content { get; set; }
        public string Proposals { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Age.ToString()))
            {
                yield return new ValidationResult("You must set your age, please.");
            }

            if (string.IsNullOrWhiteSpace(Proposals))
            {
                yield return new ValidationResult("Please, write your proposals.");
            }
        }
    }
}