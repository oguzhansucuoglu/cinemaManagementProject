using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EmployeeContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("HostingConnection")));

builder.Services.AddDbContext<DepartmentContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("HostingConnection")));

builder.Services.AddDbContext<CinemaContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("HostingConnection")));

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
