namespace Microsoft.Extensions.DependencyInjection
{
	using LessonsBg.Core.Contracts;
	using LessonsBg.Core.Services;

	public static class LessonsBgServiceCollectionExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<IBlogService, BlogService>();
			services.AddScoped<INewsService, NewsService>();

			services.AddScoped<ISubjectsService, SubjectsService>();
			services.AddScoped<ITeacherService, TeacherService>();

			services.AddScoped<ITrainingsService, TrainingsService>();
			services.AddScoped<ITrainerService, TrainerService>();

			services.AddScoped<IAcademyService, AcademyService>();
			services.AddScoped<ILocationService, LocationService>();

			services.AddScoped<ICourseService, CourseService>();

			return services;
		}
	}
}
