namespace LessonsBg.Core.Seeding
{
    using LessonsBg.Core.Data.Models;


    public static class DataSeeder
    {
        public static CourseType[] SeedCourseTypes()
        {
            return new CourseType[]
            {
                new CourseType()
                {
                    Id = 1,
                    Type = "Piano"
                },
                new CourseType()
                {
                    Id = 2,
                    Type = "Singing"
                },
                new CourseType()
                {
                    Id = 3,
                    Type = "Dancing"
                },
                new CourseType()
                {
                    Id = 4,
                    Type = "Microsoft Excel"
                }
            };
        }

        public static SubjectType[] SeedSubjectTypes()
        {
            return new SubjectType[]
            {
                new SubjectType()
                {
                    Id = 1,
                    Type = "Academic"
                },
                new SubjectType()
                {
                    Id = 2,
                    Type = "Language"
                },
                new SubjectType()
                {
                    Id = 3,
                    Type = "IT"
                }
            };
        }

        public static TrainingType[] SeedTrainingTypes()
        {
            return new TrainingType[]
            {
                new TrainingType()
                {
                    Id = 1,
                    Type = "Air sport"
                },
                new TrainingType()
                {
                    Id = 2,
                    Type = "Combat sport"
                }
            };
        }

        public static FilterBadge[] SeedFilterBadges()
        {
            return new FilterBadge[]
            {
                new FilterBadge()
                {
                    Id = 1,
                    FilterBadgeType = "1-4 Grade"
                },
                new FilterBadge()
                {
                    Id = 2,
                    FilterBadgeType = "5-8 Grade"
                },
                new FilterBadge()
                {
                    Id = 3,
                    FilterBadgeType = "9-12 Grade"
                },
                new FilterBadge()
                {
                    Id = 4,
                    FilterBadgeType = "University Students"
                },
                new FilterBadge()
                {
                    Id = 5,
                    FilterBadgeType = "Elderly"
                },
                new FilterBadge()
                {
                    Id = 6,
                    FilterBadgeType = "Online"
                },
                new FilterBadge()
                {
                    Id = 7,
                    FilterBadgeType = "Onsite"
                }
            };
        }
    }
}
