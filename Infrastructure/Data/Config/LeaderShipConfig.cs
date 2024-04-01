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
	public class LeaderShipConfig : IEntityTypeConfiguration<LeaderShip>
	{
		public void Configure(EntityTypeBuilder<LeaderShip> builder)
		{
			builder.ToTable(nameof(LeaderShip));
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
			builder.Property(x => x.ImageUrl).HasMaxLength(128).IsRequired();
			builder.Property(x => x.Position).HasMaxLength(128).IsRequired();
			builder.Property(d => d.CreatedBy).HasMaxLength(55).IsRequired();
			builder.Property(d => d.CreatedDate).IsRequired();
			builder.Property(d => d.UpdatedDate).IsRequired(false);
			builder.Property(d => d.UpdatedBy).IsRequired(false);
		}
	}
}
