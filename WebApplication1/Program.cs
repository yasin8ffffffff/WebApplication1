using _01.Models;
using _01.Controllers;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.Add<Numccal,example>;

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(name:"default",pattern: "{controller=API}/{action=Index}/{Numccal?}");

app.Run();
