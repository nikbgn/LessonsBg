namespace LessonsBg.Core.Data
{
    public static class DataValidationConstants
    {
        public static class BlogPostValidation
        {
            public const int BlogTitleMaxLength = 60;
            public const int BlogTitleMinLength = 10;

            public const int BlogPostTextMinLength = 10;
        }
        public static class BlogCommentValidation
        {
            public const int BlogCommentTextMaxLength = 150;
            public const int BlogCommentTextMinLength = 10;

        }
        public static class CourseValidation
        {
            public const int CourseNameMaxLength = 60;
            public const int CourseNameMinLength = 10;

            public const int CourseDescriptionMinLength = 10;
        }

        public static class NewsArticleValidation
        {
            public const int NewsArticleNameMaxLength = 60;
            public const int NewsArticleNameMinLength = 10;

            public const int NewsArticleTextMinLength = 150;
        }
    }
}
