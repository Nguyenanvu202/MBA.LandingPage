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
    public class PageConfig : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.ToTable(nameof(Page));
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Url).HasMaxLength(255).IsRequired();
			builder.Property(d => d.CreatedBy).HasMaxLength(55).IsRequired();
			builder.Property(d => d.CreatedDate).IsRequired();
			builder.Property(d => d.UpdatedDate).IsRequired(false);
			builder.Property(d => d.UpdatedBy).IsRequired(false);

			builder.HasMany(s => s.Sections)
                .WithOne(p => p.Page)
                .HasForeignKey(p => p.PageId)
                .IsRequired(false);
        }
    }
}
