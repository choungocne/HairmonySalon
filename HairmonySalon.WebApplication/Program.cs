using Harmony.Repositories;
using Harmony.Repositories.Interfaces;
using Harmony.Services;
using Harmony.Services.Interfaces;
using HarmonySalon.Reponsitories.Entities;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<HarmonySalonContext>();
//DI repo
builder.Services.AddScoped<IUserRepository, UserRepository>();
//I services
builder.Services.AddScoped<IUserService, UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
builder.Services.AddAuthentication("ApplicationCookie")
    .AddCookie("ApplicationCookie", options =>
    {
        options.LoginPath = "/Account/Login";
    });
app.UseAuthentication();
 
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Cấu hình xác thực và phân quyền
app.UseAuthentication();
app.UseAuthorization();
 
void CreateRolesAndUsers(IApplicationBuilder app)
{
    using var scope = app.ApplicationServices.CreateScope();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

    // Tạo vai trò "Admin" nếu chưa tồn tại
    if (!roleManager.RoleExistsAsync("Admin").Result)
    {
        var role = new IdentityRole("Admin");
        roleManager.CreateAsync(role).Wait();
    }

    // Tạo vai trò "Customer" nếu chưa tồn tại
    if (!roleManager.RoleExistsAsync("Customer").Result)
    {
        var role = new IdentityRole("Customer");
        roleManager.CreateAsync(role).Wait();
    }

    // Tạo vai trò "Manager" nếu chưa tồn tại
    if (!roleManager.RoleExistsAsync("Manager").Result)
    {
        var role = new IdentityRole("Manager");
        roleManager.CreateAsync(role).Wait();
    }

    // Tạo người dùng "admin" và thêm vào vai trò "Admin" nếu chưa tồn tại
    if (userManager.FindByNameAsync("admin").Result == null)
    {
        var adminUser = new User
        {
            Name = "admin",
            Email = "admin@gmail.com"
        };

        string adminPwd = "admin123";
        var result = userManager.CreateAsync(adminUser, adminPwd).Result;

        if (result.Succeeded)
        {
            userManager.AddToRoleAsync(adminUser, "Admin").Wait();
        }
    }

    // Tạo người dùng "customer" và thêm vào vai trò "Customer" nếu chưa tồn tại
    if (userManager.FindByNameAsync("customer").Result == null)
    {
        var customerUser = new User
        {
            Name = "customer",
            Email = "customer@gmail.com"
        };

        string customerPwd = "customer123";
        var result = userManager.CreateAsync(customerUser, customerPwd).Result;

        if (result.Succeeded)
        {
            userManager.AddToRoleAsync(customerUser, "Customer").Wait();
        }
    }

    // Tạo người dùng "manager" và thêm vào vai trò "Manager" nếu chưa tồn tại
    if (userManager.FindByNameAsync("manager").Result == null)
    {
        var managerUser = new User
        {
            Name = "manager",
            Email = "manager@gmail.com"
        };

        string managerPwd = "manager123";
        var result = userManager.CreateAsync(managerUser, managerPwd).Result;

        if (result.Succeeded)
        {
            userManager.AddToRoleAsync(managerUser, "Manager").Wait();
        }
    }
}


// Gọi hàm để tạo các vai trò và người dùng ban đầu
CreateRolesAndUsers(app);

app.MapControllers();
app.Run();

