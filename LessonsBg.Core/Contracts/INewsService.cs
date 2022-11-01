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
    }
}
