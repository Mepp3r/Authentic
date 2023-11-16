var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ILoginData, LoginSql>();

var app = builder.Build();

//app.UseStaticFiles();

app.MapControllerRoute("default", "{controller=User}/{action=Login}/{id?}");

app.Run();
