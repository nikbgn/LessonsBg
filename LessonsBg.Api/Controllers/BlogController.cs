namespace LessonsBg.Api.Controllers
{
    using LessonsBg.Core.Contracts;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService blogService;

        public BlogController(IBlogService _blogService)
        {
            blogService = _blogService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await blogService.GetAll());
        }
    }
}
