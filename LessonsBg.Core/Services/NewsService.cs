namespace LessonsBg.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Data.Models;
    using LessonsBg.Core.Models;

    using Microsoft.EntityFrameworkCore;

    public class NewsService : INewsService
    {

        private readonly ApplicationDbContext context;

        public NewsService(ApplicationDbContext _context)
        {
            context = _context;
        }

        /// <summary>
        /// Adds a new NewsArticle
        /// </summary>
        /// <param name="newsArticleModel">News article model.</param>

        public async Task AddAsync(NewsArticleModel newsArticleModel)
        {
            var newsArticle = new NewsArticle()
            {
                Name = newsArticleModel.Name,
                Text = newsArticleModel.Text,
                ImageURL = newsArticleModel.ImageURL,
                CreatedOn = DateTime.Now.Date
            };

            await context.AddAsync(newsArticle);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets all news
        /// </summary>
        /// <returns>All news</returns>

        public async Task<IEnumerable<NewsArticleModel>> GetAllNewsAsync()
            => await context.NewsArticles
                    .Select(n => new NewsArticleModel()
                    {
                        Id = n.Id,
                        Name = n.Name,
                        ImageURL = n.ImageURL,
                        CreatedOn = n.CreatedOn,
                        Text = n.Text
                    }).ToListAsync();

    }
}
