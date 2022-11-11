namespace LessonsBg.Core.Contracts
{
    using LessonsBg.Core.Models;

    /// <summary>
    /// Interface for the News Service.
    /// </summary>

    public interface INewsService
    {
        /// <summary>
        /// Adds a new NewsArticle
        /// </summary>
        /// <param name="newsArticleModel">News article model.</param>
        Task AddAsync(NewsArticleModel newsArticleModel);

        /// <summary>
        /// Gets all news
        /// </summary>
        /// <returns>All news</returns>
        Task<IEnumerable<NewsArticleModel>> GetAllNewsAsync();

        /// <summary>
        /// Removes a news article.
        /// </summary>
        /// <param name="newsArticleId">News article ID</param>
        Task RemoveAsync(Guid newsArticleId);

        /// <summary>
        /// Gets a specific news article by ID.
        /// </summary>
        /// <param name="newsArticleId"></param>
        /// <returns></returns>
        Task<NewsArticleModel> GetNewsArticleAsync(Guid newsArticleId);
    }
}
