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

			return services;
		}
	}
}
