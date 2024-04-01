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
    public class SectionConfig : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.ToTable(nameof(Section));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ButtonUrl).HasMaxLength(255);
            builder.Property(x => x.Name).HasMaxLength(255);

			builder.Property(d => d.CreatedBy).HasMaxLength(55).IsRequired();
			builder.Property(d => d.CreatedDate).IsRequired();
			builder.Property(d => d.UpdatedDate).IsRequired(false);
			builder.Property(d => d.UpdatedBy).IsRequired(false);

			builder.HasOne(p => p.SectionParent)
                .WithMany(s => s.Sections)
                .HasForeignKey(s => s.SectionParentId)
                .IsRequired(false);
        }
    }
}
