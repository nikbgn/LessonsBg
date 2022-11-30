namespace LessonsBg.Core.Models.Subject
{
    public class AllLessonsModel
    {
        public string SubjectTypeName { get; set; } = null!;

        public List<string> SubjectsOfSubjectTypeName { get; set; } = new List<string>();
    }
}
