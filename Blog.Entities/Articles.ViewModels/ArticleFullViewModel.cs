using System.Collections.Generic;
using Blog.Entities.Hashtags;

namespace Blog.Entities.Articles.ViewModels
{
    public class ArticleFullViewModel
    {
        public ArticleItem Article { get; set; }

        public List<Hashtag> HashtagsList = new List<Hashtag>();
    }
}
