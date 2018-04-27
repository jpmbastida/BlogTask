using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogTask.Models
{
    public static class Polls
    {
        public static List<PollItem> AllPolls = new List<PollItem>();
        static object _objLock = new Object();

        public static void AddPoll(PollItem poll)
        {
            lock (_objLock)
            {
                AllPolls.Add(poll);
            }
        }
    }
}