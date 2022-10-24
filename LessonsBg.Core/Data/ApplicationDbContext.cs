namespace LessonsBg.Core.Data
{
    using LessonsBg.Core.Data.Models;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //TODO: Seed initial data.
            base.OnModelCreating(builder);
        }
    }
}