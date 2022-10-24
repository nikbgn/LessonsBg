namespace LessonsBg.Core.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser
    {
        public IEnumerable<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
    }
}
