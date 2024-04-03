using Core.Models.Repository;
using Infrastructure.Data;
using Infrastructure.Data.Repository;
using MBA.site.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

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
builder.Services.AddDbContext<MBAContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("MBADatabaseConnectionString")));
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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
