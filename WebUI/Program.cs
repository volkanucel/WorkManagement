using DataAccessLayer.Concrete.EntityFramework.Context;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("WorkManagementDB")));

//builder.Services.ConfigureApplicationCookie(option =>
//{
//    option.LoginPath = "/Login";
//    option.LogoutPath = "/Register";
//});


builder.Services.AddAuthentication().AddCookie(x =>
{
    x.LoginPath = "/Login";
    x.LogoutPath = "/Login";
});

builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
{
    x.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<DataContext>();

var app = builder.Build();





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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

app.Run();
