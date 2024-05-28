using Mba.Admin.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mba.Admin.Areas.Identity.Data;

public class MbaAdminContext : IdentityDbContext<MbaAdminUser>
{
    public MbaAdminContext(DbContextOptions<MbaAdminContext> options)
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=Sechiii\\SQLEXPRESS;Database=Mba.Admin;Trusted_Connection=True; TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
