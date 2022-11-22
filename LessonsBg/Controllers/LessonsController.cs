namespace LessonsBg.Controllers
{
	using LessonsBg.Core.Contracts;

	using Microsoft.AspNetCore.Mvc;

	public class LessonsController : Controller
	{

		private readonly ISubjectsService subjectsService;
		private readonly ITeacherService teachersService;

		public LessonsController(ISubjectsService _subjectsService, ITeacherService _teachersService)
		{
			subjectsService = _subjectsService;
			teachersService = _teachersService;
		}


		public async Task<IActionResult> All()
		{

			//Get all subject types names
			var subjectTypesNames = await subjectsService.GetAllSubjectTypesNamesAsync();
			var allLessonsModel = await subjectsService.GetAllLessonsAsync(subjectTypesNames);
			
			return View(allLessonsModel);
		}

		[HttpPost]
		public async Task<IActionResult> LessonsFor(string subjectName)
		{
			var subjectNames = await subjectsService.GetAllSubjectNamesAsync();
			if(!subjectNames.Any(s => s == subjectName))
			{
				return BadRequest();
			}

			//Get teachers for subject List<TeacherModel> and pass to view...
			var teachers = await teachersService.GetTeachersCardsForSubjectAsync(subjectName);

			return View(teachers);
		}
	}
}
