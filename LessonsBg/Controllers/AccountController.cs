﻿namespace LessonsBg.Controllers
{
    using LessonsBg.Core.Data;
    using LessonsBg.Core.Data.Models;
    using LessonsBg.Models;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using static LessonsBg.Core.Data.ApplicationErrorMessages;

    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(
            UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager,
            RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if((model.FirstName.ToLower() == "академия" || model.LastName.ToLower() == "академия") && model.RegistrationFlag != 4)
            {
                ModelState.AddModelError("", InvalidRegistrationAcademyError);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var newUser = new ApplicationUser()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                UserName = model.Email
            };

            var result = await userManager.CreateAsync(newUser, model.Password);

            if (model.RegistrationFlag == 2) await userManager.AddToRoleAsync(newUser, RoleConstants.Teacher);
            else if (model.RegistrationFlag == 3) await userManager.AddToRoleAsync(newUser, RoleConstants.Trainer);
            else if (model.RegistrationFlag == 4) await userManager.AddToRoleAsync(newUser, RoleConstants.Academy);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(newUser, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }


        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            var model = new LoginViewModel()
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                //TODO: Persistance false by default, since remember me form is not added yet.
                var result = await signInManager.PasswordSignInAsync(user, model.Password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    if (model.ReturnUrl != null) return Redirect(model.ReturnUrl);
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", InvalidLogin);
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> CreateRoles()
        {
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Administrator));
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Academy));
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Teacher));
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Trainer));

            return RedirectToAction("Index", "Home");
        }

    }
}