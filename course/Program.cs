using course.Data;
using course.Data.Interface;
using course.Data.SQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(op =>
{
    var cs = builder.Configuration.GetConnectionString("Default");
    op.UseMySql(cs, ServerVersion.AutoDetect(cs));
});

builder.Services.AddScoped<ICoursesRepo, MySqlCourseRepo>();
builder.Services.AddScoped<IInstructorRepo, MySqlInstructorRepo>();
builder.Services.AddScoped<IStudentRepo, MySqlStudentRepo>();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
