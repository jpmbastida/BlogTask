﻿using System.Collections.Generic;
using System.Linq;
using Blog.Data.Context;
using Blog.Entities.Polls;
using Blog.Entities.Polls.ViewModels;

namespace Blog.Data.Repositories
{
    /// <summary>
    /// Usage: 
    /// Implements the Repository for Polls.
    /// This repository includes methods <see cref="GetAll()"/> and <see cref="SavePoll(PollViewModel)"/> for obtaining all Polls and Adding a new Poll.
    /// </summary>
    public class PollRepository
    {
        /// <summary>
        /// Usage: 
        /// Method for obtaining all Polls.
        /// <see cref="GetAll()"/> 
        /// </summary>
        /// <returns>PollViecModel.</returns>
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

        /// <summary>
        /// Usage: 
        /// Method for saving a Polls.
        /// <see cref="SavePoll(PollViewModel)"/> 
        /// </summary>
        /// <returns>A bool.</returns>
        /// <param name="vPoll">The Poll model from view.</param>
        public bool SavePoll(PollViewModel vPoll)
        {
            if (vPoll == null) return false;
            using (var contex = new BlogContext())
            {
                contex.MusicGenres.Add(vPoll.MusicGenres);
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
