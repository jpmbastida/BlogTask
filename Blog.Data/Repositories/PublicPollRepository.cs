using System.Data.Entity;
using System.Linq;
using Blog.Data.Context;
using Blog.Entities.PublicPolls;

namespace Blog.Data.Repositories
{
    /// <summary>
    /// Usage: 
    /// Implements the Repository for Public polls.
    /// This repository includes methods <see cref="GetPublicPoll()"/> and <see cref="UpdatePublicPoll(PublicPoll)"/> for obtaining all Polls and updating a new Poll.
    /// </summary>
    public class PublicPollRepository
    {
        /// <summary>
        /// Usage: 
        /// Method for obtaining all Polls.
        /// <see cref="GetPublicPoll()"/> 
        /// </summary>
        /// <returns>CommenViecModel.</returns>
        public PublicPoll GetPublicPoll()
        {
            using (var context = new BlogContext())
            {
                var publicPoll = context.PublicPolls.ToList();
                if (publicPoll.Count != 0)
                {
                    return publicPoll[0];
                }

                var poll = new PublicPoll
                {
                    Tech = 0,
                    Science = 0,
                    Fashion = 0,
                    Photography = 0,
                    Weather = 0
                };
                context.PublicPolls.Add(poll);
                context.SaveChanges();

                return context.PublicPolls.ToList()[0];
            }
        }

        /// <summary>
        /// Usage: 
        /// Method for obtaining all Polls.
        /// <see cref="UpdatePublicPoll(PublicPoll)"/> 
        /// </summary>
        /// <returns>CommenViecModel.</returns>
        public bool UpdatePublicPoll(PublicPoll poll)
        {
            if (poll == null)
            {
                return false;
            }

            using (var context = new BlogContext())
            {
                context.Entry(poll).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }
    }
}
