using Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
	public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.ToTable(nameof(Product));
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
			builder.Property(x => x.ImageUrl).HasMaxLength(128).IsRequired();
			builder.Property(x => x.Url).HasMaxLength(128).IsRequired();
			builder.Property(d => d.CreatedBy).HasMaxLength(55).IsRequired();
			builder.Property(d => d.CreatedDate).IsRequired();
			builder.Property(d => d.UpdatedDate).IsRequired(false);
			builder.Property(d => d.UpdatedBy).IsRequired(false);

			builder.HasMany(x => x.ProductDetails)
				.WithOne(x => x.Product)
				.HasForeignKey(x => x.ProductId)
				.IsRequired();
		}
	}
}
