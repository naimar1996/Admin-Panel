using FrontToEnd1.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
var app = builder.Build();

app.MapControllerRoute(
           name: "areas",
           pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
         );

app.MapDefaultControllerRoute();
app.UseStaticFiles();
//app.MapControllerRoute(
//    name: "default",
//    pattern:"{contoller:home}/{action:index}/{id?}"
//    );
app.Run();
