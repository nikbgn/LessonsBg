namespace LessonsBg.Areas.Trainer.Controllers
{
    using LessonsBg.Core.Data;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Area("Trainer")]
    [Authorize(Roles = $"{RoleConstants.Administrator}, {RoleConstants.Trainer}")]
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
