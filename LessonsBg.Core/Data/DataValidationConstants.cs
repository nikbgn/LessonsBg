namespace LessonsBg.Core.Data
{
    public static class DataValidationConstants
    {
        public static class BlogPostValidation
        {
            public const int BlogTitleMaxLength = 60;
            public const int BlogTitleMinLength = 10;

            public const int BlogPostTextMinLength = 10;


			public const string BlogPostTitleLengthErrorMessage = "Заглавието на блог поста трябва да е между {2} и {1} символа.";
			public const string BlogPostTextLengthErrorMessage = "Съдържанието на блог поста трябва да е поне {1} символа.";
			public const string BlogPostThumbnailURLErrorMessage = "Картинката на блог поста трябва да бъде валиден URL адрес!";
			public const string BlogPostTextHeadingImageURLErrorMessage = "Главната картинка на блог поста трябва да бъде валиден URL адрес!";
			public const string ThisFieldIsRequiredErrorMessage = "Попълването на това поле е задължително!";

		}
        public static class BlogCommentValidation
        {
            public const int BlogCommentTextMaxLength = 150;
            public const int BlogCommentTextMinLength = 10;
			public const string BlogCommentLengthErrorMessage = "Дължината на коментара трябва да е между {2} и {1} символа.";
			public const string ThisFieldIsRequiredErrorMessage = "Попълването на това поле е задължително!";

		}
        public static class CourseValidation
        {
            public const int CourseNameMaxLength = 60;
            public const int CourseNameMinLength = 10;

            public const int CourseDescriptionMinLength = 10;

			public const string CourseNameErrorMessage = "Името на курса трябва да е между {2} и {1} символа.";
			public const string CourseDescriptionErrorMessage = "Описанието на курса трябва да е миминум {1} символа.";
			public const string CourseImageErrorMessage = "Картинката на курса трябва да е валиден URL адрес!";
			public const string CourseWebsiteErrorMessage = "Уебсайта на курса трябва да е валиден URL адрес!";
			public const string CoursePhoneNumberErrorMessage = "Телефонът за контакти трябва да е валиден български номер! (08XXXXXXXX)";
			public const string ThisFieldIsRequiredErrorMessage = "Попълването на това поле е задължително!";


		}
        public static class NewsArticleValidation
        {
            public const int NewsArticleNameMaxLength = 240;
            public const int NewsArticleNameMinLength = 10;

            public const int NewsArticleTextMinLength = 150;

            public const string NewsArticleNameLengthErrorMessage = "Името на новината трябва да е между {2} и {1} символа.";
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
