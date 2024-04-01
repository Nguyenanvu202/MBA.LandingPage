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
    public class DescribeConfig : IEntityTypeConfiguration<Describe>
    {
        public void Configure(EntityTypeBuilder<Describe> builder)
        {
            builder.ToTable(nameof(Describe));
            builder.HasKey(x => x.Id);
            builder.Property(n => n.Name).HasMaxLength(256).IsRequired();
            builder.Property(d => d.Description).HasMaxLength(1024).IsRequired();
            builder.Property(d => d.CreatedBy).HasMaxLength(55).IsRequired();
            builder.Property(d => d.CreatedDate).IsRequired();
            builder.Property(d => d.UpdatedDate).IsRequired(false);
            builder.Property(d => d.UpdatedBy).IsRequired(false);

            builder.HasOne(s => s.Section)
                .WithMany(d => d.Describes)
                .HasForeignKey(d => d.SectionId)
                .IsRequired();
        }
    }
}
