using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Dto.Factories
{
    public interface IArticleFactory
    {
        ArticleDto CreateArticle(Article article);
    }

    public class ArticleFactory : IArticleFactory
    {
        public ArticleDto CreateArticle(Article article)
        {
            var articleDto = new ArticleDto
            {
                Id = article.Id,
                Title = article.Title,
                Subtitle = article.Subtitle,
                Body = article.Body,
                Likes = article.Likes,
                Comments = article.Comments,
                PublishedAgo = SetTimeAgo(article.PublishDate),
                Author = article.Author
            };

            return articleDto;
        }

        private string SetTimeAgo(DateTime postedDate)
        {
            var postedAgo = DateTime.Now - postedDate;

            if (postedAgo.Days > 0)
            {
                return postedAgo.Days.ToString() + " days ago";
            }
            else if (postedAgo.Hours > 0)
            {
                return postedAgo.Minutes.ToString() + " hours ago";
            }
            else if (postedAgo.Minutes > 0)
            {
                return postedAgo.Hours.ToString() + " minutes ago";
            }
            else
            {
                return "now";
            }
        }
    }
}
