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
	public class ProductDetailConfig : IEntityTypeConfiguration<ProductDetail>
	{
		public void Configure(EntityTypeBuilder<ProductDetail> builder)
		{
			builder.ToTable(nameof(ProductDetail));
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
			builder.Property(x => x.ImageUrl).HasMaxLength(128).IsRequired();
			builder.Property(x => x.Url).HasMaxLength(128).IsRequired();
			builder.Property(x => x.Code).HasMaxLength(55).IsRequired();
			builder.Property(x => x.Status).HasMaxLength(55).IsRequired();
			builder.Property(x => x.Specifications).HasMaxLength(1024).IsRequired();
			builder.Property(x => x.Description).HasMaxLength(1024).IsRequired();
			builder.Property(d => d.CreatedBy).HasMaxLength(55).IsRequired();
			builder.Property(d => d.CreatedDate).IsRequired();
			builder.Property(d => d.UpdatedDate).IsRequired(false);
			builder.Property(d => d.UpdatedBy).IsRequired(false);

		}
	}
}
