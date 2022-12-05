namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using global::LessonsBg.Core.Data.Models;
	using global::LessonsBg.Core.Services;

	using Microsoft.Extensions.Logging;

	using Moq;

	public class CourseServiceTests
	{
		private readonly ILogger<CourseService> ILoggerMock = new Mock<ILogger<CourseService>>().Object;

		[Fact]
		public async void CourseService_GetAllCourses_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var courseService = new CourseService(db.DbContext, this.ILoggerMock);

			var courseType = db.DbContext.CourseTypes.First();
			var location = new Location() { Id = 1, Name = "Онлайн", Region = "Онлайн" };

			Course course = new Course()
			{
				Id = Guid.NewGuid(),
				CourseName = "Nice course!",
				CourseDescription = "This is a very nice course!",
				CourseImageURL = "https://prod-discovery.edx-cdn.org/media/course/image/156313d6-f892-4b08-9cee-43ea582f4dfb-7b98c686abcc.small.png",
				CourseType = courseType,
				CourseTypeId = courseType.Id,
				PhoneNumber = "0891472589",
				Location = location,
				LocationId = location.Id
			};

			db.DbContext.Courses.Add(course);
			db.DbContext.SaveChanges();

			var courses = await courseService.GetAllCoursesAsync();

			Assert.True(courses.Count() > 0);
			Assert.True(courses.First().Id == course.Id);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void CourseService_GetCourseInDepthInfoById_Works()
		{

			DatabaseSetup db = new DatabaseSetup();

			var courseService = new CourseService(db.DbContext, this.ILoggerMock);

			var courseType = db.DbContext.CourseTypes.First();
			var location = new Location() { Id = 1, Name = "Онлайн", Region = "Онлайн" };

			Course course = new Course()
			{
				Id = Guid.NewGuid(),
				CourseName = "Nice course!",
				CourseDescription = "This is a very nice course!",
				CourseImageURL = "https://prod-discovery.edx-cdn.org/media/course/image/156313d6-f892-4b08-9cee-43ea582f4dfb-7b98c686abcc.small.png",
				CourseType = courseType,
				CourseTypeId = courseType.Id,
				PhoneNumber = "0891472589",
				Location = location,
				LocationId = location.Id
			};

			db.DbContext.Courses.Add(course);
			db.DbContext.SaveChanges();

			var courseInDepthInfo = await courseService.GetCourseInDepthInfoById(course.Id);

			Assert.True(courseInDepthInfo.CourseModel.Id == course.Id);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void CourseService_GetCourseInDepthInfoById_Throws_Exception()
		{

			DatabaseSetup db = new DatabaseSetup();

			var courseService = new CourseService(db.DbContext, this.ILoggerMock);

			var badGuid = Guid.NewGuid();

			await Assert.ThrowsAnyAsync<Exception>(() => courseService.GetCourseInDepthInfoById(badGuid));

			db.DbContext.Dispose();
		}

		[Fact]
		public async void CourseService_GetCourseTypeById_Works()
		{

			DatabaseSetup db = new DatabaseSetup();

			var courseService = new CourseService(db.DbContext, this.ILoggerMock);

			var getCourseTypeFromDb = db.DbContext.CourseTypes.First(c => c.Id == 1);

			var courseType = await courseService.GetCourseTypeByIdAsync(1);

			Assert.NotNull(courseType);
			Assert.True(courseType.Id == getCourseTypeFromDb.Id);
			Assert.True(courseType.Type == getCourseTypeFromDb.Type);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void CourseService_GetCourseTypeById_Throws_Exception()
		{

			DatabaseSetup db = new DatabaseSetup();

			var courseService = new CourseService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => courseService.GetCourseTypeByIdAsync(-1));

			db.DbContext.Dispose();
		}

		[Fact]
		public async void CourseService_GetCourseTypes_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var courseService = new CourseService(db.DbContext, this.ILoggerMock);

			var courseTypes = await courseService.GetCourseTypesAsync();
			var dbCourseTypesCount = db.DbContext.CourseTypes.Count();

			Assert.NotNull(courseTypes);
			Assert.True(courseTypes.Count() == dbCourseTypesCount);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void CourseService_GetCourseById_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var courseService = new CourseService(db.DbContext, this.ILoggerMock);

			var courseType = db.DbContext.CourseTypes.First();
			var location = new Location() { Id = 1, Name = "Онлайн", Region = "Онлайн" };

			Course course = new Course()
			{
				Id = Guid.NewGuid(),
				CourseName = "Nice course!",
				CourseDescription = "This is a very nice course!",
				CourseImageURL = "https://prod-discovery.edx-cdn.org/media/course/image/156313d6-f892-4b08-9cee-43ea582f4dfb-7b98c686abcc.small.png",
				CourseType = courseType,
				CourseTypeId = courseType.Id,
				PhoneNumber = "0891472589",
				Location = location,
				LocationId = location.Id
			};

			db.DbContext.Courses.Add(course);
			db.DbContext.SaveChanges();

			var getCourse = await courseService.GetCourseByIdAsync(course.Id);

			Assert.True(getCourse.Id == course.Id);
			Assert.True(getCourse.CourseName == course.CourseName);
			Assert.True(getCourse.CourseDescription == course.CourseDescription);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void CourseService_GetCourseById_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var courseService = new CourseService(db.DbContext, this.ILoggerMock);

			var badGuid = Guid.NewGuid();

			await Assert.ThrowsAnyAsync<Exception>(() => courseService.GetCourseByIdAsync(badGuid));

			db.DbContext.Dispose();
		}
	}
}
