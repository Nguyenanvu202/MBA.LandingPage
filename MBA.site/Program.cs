using Core.Models.Repository;
using Infrastructure.Data;
using Infrastructure.Data.Repository;
using MBA.site.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.AspNetCore.ResponseCompression;
using MBA.site.Pages.Site.Account;
using Microsoft.AspNetCore.Components.Authorization;
using MBA.site.Pages.Site.Account.Components.Account;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<MBAContext>();
builder.Services.AddBlazorBootstrap();
builder.Services.AddScoped<IPageRepo, PageRepo>();
builder.Services.AddScoped<ISectionRepo, SectionRepo>();
builder.Services.AddScoped<IDescribeRepo, DescribeRepo>();
builder.Services.AddScoped<IImageRepo, ImageRepo>();
builder.Services.AddScoped<ILeaderShipRepo, LeaderShipRepo>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IProductDetailRepo, ProductDetailRepo>();


builder.Services.AddDbContext<MBAContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("MBADatabaseConnectionString")));
//Identity
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<Infrastructure.Data.ApplicationDbContext>();
var connectionString = builder.Configuration.GetConnectionString("MBAIdentityConnectionString");
builder.Services.AddDbContext<Infrastructure.Data.ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();


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

app.UseAuthentication();
app.UseAuthorization();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
