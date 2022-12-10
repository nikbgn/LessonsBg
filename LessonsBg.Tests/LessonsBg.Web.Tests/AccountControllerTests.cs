using LessonsBg.Core.Contracts;
using LessonsBg.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace LessonsBg.Tests.LessonsBg.Web.Tests
{
    public class AccountControllerTests
    {
        private readonly Mock<UserManager<ApplicationUser>> userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null, null, null, null, null, null, null, null);
        private readonly Mock<SignInManager<ApplicationUser>> signInManagerMock = new Mock<SignInManager<ApplicationUser>>();
        private readonly Mock<RoleManager<IdentityRole>> roleManagerMock = new Mock<RoleManager<IdentityRole>>();
        private readonly Mock<IAccountService> accountServiceMock = new Mock<IAccountService>();
        private readonly Mock<ILogger<AccountController>> loggerMock = new Mock<ILogger<AccountController>>();

        [Fact]
        public async Task AccessDenied_Should_Return_View()
        {
            var accountController = new AccountController
                (null,
                null,
                null,
                null,
                null);

            var result = accountController.AccessDenied();
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task GET_Register_Should_Return_View()
        {
            var accountController = new AccountController
                (userManagerMock.Object,
                null,
                null,
                accountServiceMock.Object,
                loggerMock.Object);

            var result = accountController.Register();
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task GET_Login_Should_Return_View()
        {
            var accountController = new AccountController
                (userManagerMock.Object,
                null,
                null,
                accountServiceMock.Object,
                loggerMock.Object);

            var result = accountController.Login();
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task Manage_Should_Return_View()
        {
            var accountController = new AccountController
                (null,
                null,
                null,
                null,
                null);

            var result = accountController.Manage();
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task GET_ChangeEmail_Should_Return_View()
        {
            var accountController = new AccountController
                (null,
                null,
                null,
                null,
                null);

            var result = accountController.ChangeEmail();
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task GET_ChangePassword_Should_Return_View()
        {
            var accountController = new AccountController
                (null,
                null,
                null,
                null,
                null);

            var result = accountController.ChangePassword();
            Assert.IsType<ViewResult>(result);

        }


        [Fact]
        public async Task GET_ChangePhoneNumber_Should_Return_View()
        {
            var accountController = new AccountController
                (null,
                null,
                null,
                null,
                null);

            var result = accountController.ChangePhoneNumber();
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task GET_ChangeAccountProfileImage_Should_Return_View()
        {
            var accountController = new AccountController
                (null,
                null,
                null,
                null,
                null);

            var result = accountController.ChangeAccountProfileImage();
            Assert.IsType<ViewResult>(result);

        }

        
    }
}
