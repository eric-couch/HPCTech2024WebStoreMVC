using Microsoft.EntityFrameworkCore;
using HPCTech2024WebStoreMVC.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Hpctech2024SpringOrderSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HPCTech2024SpringOrderSystemContext")));

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
// https://localhost:7149/Home/Index
// https://localhost:7149/
// Server=(localdb)\\mssqllocaldb;Database=HPCTech2024SpringOrderSystem;Trusted_Connection=True;
app.Run();
