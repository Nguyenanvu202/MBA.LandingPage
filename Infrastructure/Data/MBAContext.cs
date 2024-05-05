using Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public sealed class MBAContext : DbContext 
    {
        public MBAContext(DbContextOptions<MBAContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			new DbInitializer(modelBuilder).Seed();
		}
        public DbSet<Page> Pages { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Describe> Describes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<LeaderShip> LeaderShips { get; set; }
    }
}
