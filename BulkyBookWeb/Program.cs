using BulkyBookWeb.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); // 

// Add services to the container.
builder.Services.AddControllersWithViews(); // Register our DB we have to create builder . Razor Pages'te burası değişecek.

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(


    builder.Configuration.GetConnectionString("DefaultConnection") // DB bağlantısı, appsettings.json'daki SQL server yoludur.



    ));
builder.Services.AddRazorPages().AddRazorRuntimeCompilation(); // Frontend compile

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // middleware

app.UseRouting(); // middleware

//app.UseAuthentication(); Authoraztion'dan önce gelir. 
app.UseAuthorization(); // middleware 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
