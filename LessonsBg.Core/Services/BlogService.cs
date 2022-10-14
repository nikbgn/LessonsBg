namespace LessonsBg.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Models;

    using Microsoft.Extensions.Configuration;

    using Newtonsoft.Json;


    /// <summary>
    /// Manipulates blog post data.
    /// </summary>

    public class BlogService : IBlogService
    {
        private readonly IConfiguration config;

        /// <summary>
        /// Inversion of control.
        /// </summary>
        /// <param name="_config">Application configuration.</param>

        public BlogService(IConfiguration _config)
        {
            config = _config;
        }

        /// <summary>
        /// Gets all blog posts.
        /// </summary>
        /// <returns>List of blog posts.</returns>

        public async Task<IEnumerable<BlogPostDto>> GetAll()
        {
            string dataPath = config.GetSection("DataFiles:BlogPosts").Value;
            string data = await File.ReadAllTextAsync(dataPath);

            return JsonConvert.DeserializeObject<IEnumerable<BlogPostDto>>(data);
        }
    }
}
