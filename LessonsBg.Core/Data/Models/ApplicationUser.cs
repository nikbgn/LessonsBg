namespace LessonsBg.Core.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser
    {
        public IEnumerable<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
        public IEnumerable<Course> Courses { get; set; } = new List<Course>();
        public IEnumerable<Subject> Subjects { get; set; } = new List<Subject>();
        public IEnumerable<Training> Trainings { get; set; } = new List<Training>();
    }
}
