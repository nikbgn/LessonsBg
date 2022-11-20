namespace LessonsBg.Core.Data
{
    using LessonsBg.Core.Data.Configuration;
    using LessonsBg.Core.Data.Models;
    using LessonsBg.Core.Models;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    using Newtonsoft.Json;


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        private readonly IConfiguration config;
		private readonly RoleManager<IdentityRole> roleManager;

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration _config)
            : base(options)
        {
            config = _config;
		}

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<FilterBadge> FilterBadges { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectType> SubjectTypes { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingType> TrainingTypes { get; set; }
        public DbSet<NewsArticle> NewsArticles { get; set; }



        protected override async void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CourseTypeConfiguration());
            builder.ApplyConfiguration(new SubjectTypeConfiguration());
            builder.ApplyConfiguration(new TrainingTypeConfiguration());
            builder.ApplyConfiguration(new FilterBadgeConfiguration());
            builder.ApplyConfiguration(new SubjectConfiguration());

            base.OnModelCreating(builder);

            builder.Entity<Location>()
                .HasData(SeedLocations());


			builder.Entity<ApplicationUserSubject>()
	            .HasKey(x => new { x.ApplicationUserId, x.SubjectId });


		}

        protected List<Location> SeedLocations()
        {
            string dataPath = config.GetSection("DataFiles:Locations").Value;
            string data = File.ReadAllText(dataPath);
            
            var locationsModel =  JsonConvert.DeserializeObject<LocationModel[]>(data);
            var locations = new List<Location>();
            int i = 1;
            foreach (var location in locationsModel)
            {
                Location newLocation = new Location()
                {
                    Id = i,
                    Name = location.Name,
                    Region = location.Region
                };
                locations.Add(newLocation);
                i++;
            }
            return locations;

        }
    }
}