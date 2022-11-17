using LessonsBg.Core.Contracts;
using LessonsBg.Core.Data;
using LessonsBg.Core.Data.Models;
using LessonsBg.Core.Services;


using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:RequireConfirmedAccount");
    options.Password.RequireDigit = builder.Configuration.GetValue<bool>("Identity:RequireDigit"); 
    options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:RequireNonAlphanumeric"); 
    options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:RequiredLength"); 
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

builder.Services.AddControllersWithViews();
builder.Services.AddApplicationServices();

var app = builder.Build();

//Check for roles existing, and create them if they do not.
using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await ConfigureRolesAndAdmin(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();


async Task ConfigureRolesAndAdmin(IServiceProvider serviceProvider)
{
    var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
	if (!roleManager.Roles.Any())
	{
		await roleManager.CreateAsync(new IdentityRole(RoleConstants.Administrator));
		await roleManager.CreateAsync(new IdentityRole(RoleConstants.Academy));
		await roleManager.CreateAsync(new IdentityRole(RoleConstants.Teacher));
		await roleManager.CreateAsync(new IdentityRole(RoleConstants.Trainer));
	}

    var admin = await userManager.FindByEmailAsync("niki_admin@niki.bg");
    await userManager.AddToRoleAsync(admin, RoleConstants.Administrator);
}