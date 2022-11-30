namespace LessonsBg.Core.Models.Course
{
    public class CreateCourseModel
    {
        public CourseModel CourseModel { get; set; }

        public IEnumerable<LocationModel> Locations { get; set; }

        public IEnumerable<CourseTypeModel> CourseTypes { get; set; }
    }
}
