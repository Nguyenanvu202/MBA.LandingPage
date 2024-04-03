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
    public class ImageConfig : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable(nameof(Image));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Url).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(55).IsRequired(false);
			builder.Property(d => d.CreatedBy).HasMaxLength(55).IsRequired();
			builder.Property(d => d.CreatedDate).IsRequired();
			builder.Property(d => d.UpdatedDate).IsRequired(false);
			builder.Property(d => d.UpdatedBy).IsRequired(false);

			builder.HasOne(x => x.Section)
                .WithMany(i => i.Images)
                .HasForeignKey(x => x.SectionId)
                .IsRequired();
        }
    }
}
