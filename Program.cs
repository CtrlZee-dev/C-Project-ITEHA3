using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using myySmartOnlineMart.Models;
using myySmartOnlineMart.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MySmartOnlineDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString);
});

// Add Identity services
builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // Add roles support
    .AddEntityFrameworkStores<MySmartOnlineDbContext>();

// Register the CartService
builder.Services.AddScoped<CartService>();
// In Program.cs (for .NET 6 or later)
builder.Services.AddScoped<ProductService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Ensure authentication is used
app.UseAuthorization();

app.MapRazorPages();

app.Run();
