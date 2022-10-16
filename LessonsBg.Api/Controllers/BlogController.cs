namespace LessonsBg.Api.Controllers
{
    using LessonsBg.Core.Contracts;
    using LessonsBg.Core.Models;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService blogService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_blogService"></param>

        public BlogController(IBlogService _blogService)
        {
            blogService = _blogService;
        }

        /// <summary>
        /// Get all blog posts.
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof(IEnumerable<BlogPostDto>))]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await blogService.GetAll());
        }
    }
}
