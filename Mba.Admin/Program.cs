using Core.Models.Repository;
using Infrastructure.Data.Repository;
using Infrastructure.Data;
using Mba.Admin.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Radzen;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Mba.Admin.Areas.Identity.Data;
using Mba.Admin.Areas.Identity.Service;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
//Register service
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();

builder.Services.AddTransient<IProductRepo, ProductRepo>();
builder.Services.AddTransient<IProductDetailRepo, ProductDetailRepo>();
builder.Services.AddDbContext<MBAContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MBADatabaseConnectionString")), ServiceLifetime.Transient);
builder.Services.AddDbContext<MbaAdminContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("MbaAdminContextConnection")), ServiceLifetime.Transient);
//Authentication
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddAuthentication("Identity.Application").AddCookie();
builder.Services.AddIdentity<MbaAdminUser, IdentityRole>()
                    .AddEntityFrameworkStores<MbaAdminContext>()
                    .AddDefaultTokenProviders()
                    .AddDefaultUI();
builder.Services.AddTransient<RoleService>();
builder.Services.AddScoped<UserRoleService>();
builder.Services.AddTransient<UserService>();

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
