using System.Collections.Generic;
using System.Linq;
using Blog.Data.Context;
using Blog.Entities.Polls;
using Blog.Entities.Polls.ViewModels;

namespace Blog.Data.Repositories
{
    public class PollRepository
    {
        public PollViewModel GetAll()
        {
            using (var context = new BlogContext())
            {
                PollViewModel pollsToDisplay = new PollViewModel();
                List<Polls> polls = new List<Polls>();
                polls = context.Polls.ToList();

                if (polls != null)
                {
                    List<PollItem> allPolls = new List<PollItem>();
                    foreach (var poll in polls)
                    {
                        allPolls.Add(
                            new PollItem()
                            {
                                Id = poll.PollId,
                                Genre = poll.Genre,
                                Age = poll.Age,
                                Proposals = poll.Proposals,
                                MusicGenres = context.MusicGenres.Find(poll.MusicGenresId),
                                Content = context.KindOfContents.Find(poll.KindOfContentsId)
                            }
                        );
                    }
                    pollsToDisplay.PollItems = allPolls;
                    return pollsToDisplay;
                }
            }
            return null;
        }

        public bool SaveComment(PollViewModel vPoll)
        {
            if (vPoll == null) return false;
            using (var contex = new BlogContext())
            {
                contex.MusicGenres.Add(vPoll.MusicGenres);
                contex.SaveChanges();
                contex.KindOfContents.Add(vPoll.Content);
                contex.SaveChanges();

                var poll = new Polls()
                {
                    Genre = vPoll.Genre,
                    Age = vPoll.Age,
                    Proposals = vPoll.Proposals,
                    MusicGenresId = contex.MusicGenres.Max(e => e.MusicGenresId),
                    KindOfContentsId = contex.KindOfContents.Max(e => e.KindOfContentsId)
                };
                contex.Polls.Add(poll);
                contex.SaveChanges();
                return true;
            }
        }
    }
}
