using SIstema_de_Informacion_Hospital_SJD;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// desde aqu�
var connectionString =
    builder.Configuration.GetConnectionString
    ("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer
    (connectionString), ServiceLifetime.Transient);

builder.Services.AddDefaultIdentity<IdentityUser>(
    options =>
    options.SignIn.RequireConfirmedAccount =
    false).AddEntityFrameworkStores<AppDbContext>();
//hasta aqu�

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may
    // want to change this for production
    // escenarios con https./2d2 mc/acentos-
}