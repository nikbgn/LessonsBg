namespace LessonsBg.Areas.Academy.Controllers
{
    using LessonsBg.Core.Data;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Area("Academy")]
    [Authorize(Roles = $"{RoleConstants.Administrator}, {RoleConstants.Academy}")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
