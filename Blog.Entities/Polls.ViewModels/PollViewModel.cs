using Blog.Entities.Contents;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Polls.ViewModels
{
    /// <inheritdoc />
    /// <summary>
    /// Usage: 
    /// This class <c>PollViewModel</c> implements the poll data model for the View with validation for <see cref="P:Blog.Entities.Polls.ViewModels.PollViewModel.Age" />
    /// and <see cref="P:Blog.Entities.Polls.ViewModels.PollViewModel.Proposals" />.
    /// </summary>
    public class PollViewModel : IValidatableObject
    {
        public int PollId { get; set; }
        public bool Genre { get; set; }
        [Range(1,120)]
        public int Age { get; set; }
        public MusicGenres MusicGenres { get; set; }
        public KindOfContents Content { get; set; }
        public string Proposals { get; set; }

        public List<PollItem> PollItems { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Age.ToString()))
            {
                yield return new ValidationResult("You must set a proper age, please.");
            }

            if (string.IsNullOrWhiteSpace(Proposals))
            {
                yield return new ValidationResult("Please, write your proposals.");
            }
        }
    }
}