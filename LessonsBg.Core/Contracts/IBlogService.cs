namespace LessonsBg.Core.Contracts
{
    using LessonsBg.Core.Models;

    /// <summary>
    /// Manipulates blog post data.
    /// </summary>

    public interface IBlogService
    {
        /// <summary>
        /// Gets all blog posts.
        /// </summary>
        /// <returns>List of blog posts.</returns>

        Task<IEnumerable<BlogPostModel>> GetAllAsync();

        /// <summary>
        /// Adds a new blog post
        /// </summary>
        /// <returns></returns>
        Task AddAsync(BlogPostModel model);
    }
}
