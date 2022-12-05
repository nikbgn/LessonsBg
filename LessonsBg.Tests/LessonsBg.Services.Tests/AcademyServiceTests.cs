namespace LessonsBg.Tests.LessonsBg.Services.Tests
{
	using System;

	using global::LessonsBg.Core.Models;
	using global::LessonsBg.Core.Models.Course;
	using global::LessonsBg.Core.Services;


	using Microsoft.Extensions.Logging;
	using Moq;

	public class AcademyServiceTests
	{
		private readonly ILogger<AcademyService> ILoggerMock = new Mock<ILogger<AcademyService>>().Object;

		[Fact]
		public async void TrainingsService_GetAllSports_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var academyService = new AcademyService(db.DbContext, this.ILoggerMock);

			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");


			var courseModel = new CourseModel()
			{
				
				CourseImageURL = "https://www.some-link.com/some_image.png",
				CourseName = "Course for beginners",
				CourseDescription = "This is a very nice course for beginners",
				CourseTypeId = 1,
				LocationId = 1,
				PhoneNumber = "0891244589",
				Website = null
			};

			var locationModel = new LocationModel()
			{
				Id = 1,
				Name = "Online",
				Region = "Online"
			};

			var courseTypeModel = new CourseTypeModel()
			{
				Id = 1,
				Type = "Пиано"
			};

			var createCourseModel = new CreateCourseModel()
			{
				CourseModel = courseModel,
				Locations = new List<LocationModel>(),
				CourseTypes = new List<CourseTypeModel>()
			};

			int adminCoursesBefore = admin.ApplicationUsersCourses.Count;

			await academyService.CreateCourse(admin.Id,createCourseModel,locationModel,courseTypeModel);

			int adminCoursesAfter = admin.ApplicationUsersCourses.Count;

			Assert.True(adminCoursesBefore < adminCoursesAfter);

			db.DbContext.Dispose();
		}

		[Theory]
		[InlineData("Cooool title edit", null)]
		[InlineData("Cooool title edit 2", "https://www.super-cool-website.com")]
		public async void TrainingsService_EditCourseAsync_Works(string title, string website)
		{
			DatabaseSetup db = new DatabaseSetup();

			var academyService = new AcademyService(db.DbContext, this.ILoggerMock);

			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");


			var courseModel = new CourseModel()
			{

				CourseImageURL = "https://www.some-link.com/some_image.png",
				CourseName = "Course for beginners",
				CourseDescription = "This is a very nice course for beginners",
				CourseTypeId = 1,
				LocationId = 1,
				PhoneNumber = "0891244589",
				Website = null
			};

			var locationModel = new LocationModel()
			{
				Id = 1,
				Name = "Online",
				Region = "Online"
			};

			var courseTypeModel = new CourseTypeModel()
			{
				Id = 1,
				Type = "Пиано"
			};

			var createCourseModel = new CreateCourseModel()
			{
				CourseModel = courseModel,
				Locations = new List<LocationModel>(),
				CourseTypes = new List<CourseTypeModel>()
			};

			int adminCoursesBefore = admin.ApplicationUsersCourses.Count;

			await academyService.CreateCourse(admin.Id, createCourseModel, locationModel, courseTypeModel);

			//Edit course

			var editModel = createCourseModel;
			var courseGetId = admin.ApplicationUsersCourses.First().CourseId;
			editModel.CourseModel.Id = courseGetId;
			editModel.CourseModel.CourseName = title;
			editModel.CourseModel.Website = website;

			await academyService.EditCourseAsync(editModel);

			var editedCourse = admin.ApplicationUsersCourses.First();

			Assert.True(editedCourse.Course.CourseName == title);
			Assert.True(editedCourse.Course.Website == website);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainingsService_GetAcademyCourses_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var academyService = new AcademyService(db.DbContext, this.ILoggerMock);

			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");


			var courseModel = new CourseModel()
			{

				CourseImageURL = "https://www.some-link.com/some_image.png",
				CourseName = "Course for beginners",
				CourseDescription = "This is a very nice course for beginners",
				CourseTypeId = 1,
				LocationId = 1,
				PhoneNumber = "0891244589",
				Website = null
			};

			var locationModel = new LocationModel()
			{
				Id = 1,
				Name = "Online",
				Region = "Online"
			};

			var courseTypeModel = new CourseTypeModel()
			{
				Id = 1,
				Type = "Пиано"
			};

			var createCourseModel = new CreateCourseModel()
			{
				CourseModel = courseModel,
				Locations = new List<LocationModel>(),
				CourseTypes = new List<CourseTypeModel>()
			};

			int adminCoursesBefore = admin.ApplicationUsersCourses.Count;

			await academyService.CreateCourse(admin.Id, createCourseModel, locationModel, courseTypeModel);

			var adminCourses = await academyService.GetAcademyCoursesAsync(admin.Id);

			Assert.True(adminCourses.Count() > 0);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainingsService_GetAcademyCourses_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var academyService = new AcademyService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => academyService.GetAcademyCoursesAsync("non-existant id"));

			db.DbContext.Dispose();
		}


		[Fact]
		public async void TrainingsService_CheckAcademyIsAuthorOfCourse_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var academyService = new AcademyService(db.DbContext, this.ILoggerMock);

			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");


			var courseModel = new CourseModel()
			{

				CourseImageURL = "https://www.some-link.com/some_image.png",
				CourseName = "Course for beginners",
				CourseDescription = "This is a very nice course for beginners",
				CourseTypeId = 1,
				LocationId = 1,
				PhoneNumber = "0891244589",
				Website = null
			};

			var locationModel = new LocationModel()
			{
				Id = 1,
				Name = "Online",
				Region = "Online"
			};

			var courseTypeModel = new CourseTypeModel()
			{
				Id = 1,
				Type = "Пиано"
			};

			var createCourseModel = new CreateCourseModel()
			{
				CourseModel = courseModel,
				Locations = new List<LocationModel>(),
				CourseTypes = new List<CourseTypeModel>()
			};


			await academyService.CreateCourse(admin.Id, createCourseModel, locationModel, courseTypeModel);

			var getId = admin.ApplicationUsersCourses.First().CourseId;

			bool verification = await academyService.CheckAcademyIsAuthorOfCourse(admin.Id, getId);

			Assert.True(verification);

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainingsService_CheckAcademyIsAuthorOfCourse_Throws_Exception()
		{
			DatabaseSetup db = new DatabaseSetup();

			var academyService = new AcademyService(db.DbContext, this.ILoggerMock);

			await Assert.ThrowsAnyAsync<Exception>(() => academyService.CheckAcademyIsAuthorOfCourse("non-existent id", Guid.NewGuid()));

			db.DbContext.Dispose();
		}

		[Fact]
		public async void TrainingsService_RemoveCourse_Works()
		{
			DatabaseSetup db = new DatabaseSetup();

			var academyService = new AcademyService(db.DbContext, this.ILoggerMock);

			var admin = db.DbContext.Users.First(a => a.NormalizedEmail == "NIKI_ADMIN@NIKI.BG");


			var courseModel = new CourseModel()
			{

				CourseImageURL = "https://www.some-link.com/some_image.png",
				CourseName = "Course for beginners",
				CourseDescription = "This is a very nice course for beginners",
				CourseTypeId = 1,
				LocationId = 1,
				PhoneNumber = "0891244589",
				Website = null
			};

			var locationModel = new LocationModel()
			{
				Id = 1,
				Name = "Online",
				Region = "Online"
			};

			var courseTypeModel = new CourseTypeModel()
			{
				Id = 1,
				Type = "Пиано"
			};

			var createCourseModel = new CreateCourseModel()
			{
				CourseModel = courseModel,
				Locations = new List<LocationModel>(),
				CourseTypes = new List<CourseTypeModel>()
			};


			await academyService.CreateCourse(admin.Id, createCourseModel, locationModel, courseTypeModel);

			var getId = admin.ApplicationUsersCourses.First().CourseId;

			await academyService.RemoveCourse(getId);

			int countOfAdminCourses = admin.ApplicationUsersCourses.Count;

			Assert.True(countOfAdminCourses == 0);

			db.DbContext.Dispose();
		}


	}
}
