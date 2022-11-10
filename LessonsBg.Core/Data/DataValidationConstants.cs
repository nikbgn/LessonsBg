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

            public const string NewsArticleNameLengthErrorMessage = "Името на новината трябва да е между {1} и {2} символа.";
            public const string NewsArticleTextLengthErrorMessage = "Съдържанието на новината трябва да е поне {1} символа.";
            public const string NewsArticleImageURLErrorMessage = "Картинката на новината трябва да бъде валиден URL адрес!";
            public const string ThisFieldIsRequiredErrorMessage = "Попълването на това поле е задължително!";
        }


        public static class ApplicationUserValidation
        {
            public const int FirstNameMaxLength = 70;
            public const int FirstNameMinLength = 1;

            public const int LastNameMaxLength = 70;
            public const int LastNameMinLength = 1;

            public const int PasswordMinimumLength = 6;
        }
    }
}
