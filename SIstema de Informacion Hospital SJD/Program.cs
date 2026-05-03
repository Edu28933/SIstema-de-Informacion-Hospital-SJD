using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SIstema_de_Informacion_Hospital_SJD;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//desde aqui
var connectionString =
    builder.Configuration.GetConnectionString
    ("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer
    (connectionString), ServiceLifetime.Transient);

builder.Services.AddDefaultIdentity<IdentityUser>
    (options =>
    options.SignIn.RequireConfirmedAccount =
    false).AddEntityFrameworkStores<AppDbContext>();

//Hasta aqui
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    // The default HSTS value is 30 days. You may
    // want to change this for production
    // escenarios con https./2d2 mc/acentos-
=======
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
>>>>>>> 2d8a7edf786a91f6ec7a855457ac4835a4129d7c
=======
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
>>>>>>> 2d8a7edf786a91f6ec7a855457ac4835a4129d7c
=======
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
>>>>>>> 2d8a7edf786a91f6ec7a855457ac4835a4129d7c
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
app.UseAuthentication(); // agregar esta linea
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller:exists}/{action}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

=======
=======
>>>>>>> 2d8a7edf786a91f6ec7a855457ac4835a4129d7c
=======
>>>>>>> 2d8a7edf786a91f6ec7a855457ac4835a4129d7c
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 2d8a7edf786a91f6ec7a855457ac4835a4129d7c
=======
>>>>>>> 2d8a7edf786a91f6ec7a855457ac4835a4129d7c
=======
>>>>>>> 2d8a7edf786a91f6ec7a855457ac4835a4129d7c
