﻿namespace LessonsBg.Core.Services
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
                CreatedOn = DateTime.Now
            };

            await context.AddAsync(newsArticle);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets all news
        /// </summary>
        /// <returns>All news</returns>

        public async Task<IEnumerable<NewsArticleModel>> GetAllNewsAsync()
		{
            try
            {
				var news = await context.NewsArticles
						.Select(n => new NewsArticleModel()
						{
							Id = n.Id,
							Name = n.Name,
							ImageURL = n.ImageURL,
							CreatedOn = n.CreatedOn,
							Text = n.Text
						}).ToListAsync();

                return news;
			}
            catch (Exception)
            {

                throw new ApplicationException("Something went wrong while getting all news.");
            }
		}

		/// <summary>
		/// Gets a specific news article by ID.
		/// </summary>
		/// <param name="newsArticleId"></param>
		/// <returns></returns>

		public async Task<NewsArticleModel> GetNewsArticleAsync(Guid newsArticleId)
		{
            var newsArticle = await context.NewsArticles
                .Where(a => a.Id == newsArticleId)
                .Select(a => new NewsArticleModel
                {
                    Id = a.Id,
                    Text = a.Text,
                    Name = a.Name,
                    CreatedOn = a.CreatedOn,
                    ImageURL = a.ImageURL
                }).FirstOrDefaultAsync();

            if(newsArticle == null)
            {
                throw new ArgumentException("Invalid ID!");
            }

            return newsArticle;
		}

		/// <summary>
		/// Removes a news article.
		/// </summary>
		/// <param name="newsArticleId">News article ID</param>
		public async Task RemoveAsync(Guid newsArticleId)
        {
            var articleToDelete = context.NewsArticles.FirstOrDefault(a => a.Id == newsArticleId);
            if(articleToDelete != null)
            {
                context.NewsArticles.Remove(articleToDelete);
                await context.SaveChangesAsync();
            }
        }
	}
}
