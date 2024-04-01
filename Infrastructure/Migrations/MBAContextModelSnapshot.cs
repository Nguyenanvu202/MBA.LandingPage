﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MBAContext))]
    partial class MBAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Models.Entity.Describe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Describe", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2616),
                            Description = "VỀ CÔNG TY\r\nMBA INTERNATIONAL JSC",
                            Name = "Big Title",
                            SectionId = 3,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2614)
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2618),
                            Description = "Tổng Giám đốc - Người sáng lập MBA",
                            Name = "General Manager",
                            SectionId = 3,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2617)
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2620),
                            Description = "Let’s Grow Together!\r\nCùng đến thành công!",
                            Name = "Slogan",
                            SectionId = 3,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2619)
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2622),
                            Description = "MBA International JSC",
                            Name = "Tag",
                            SectionId = 3,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2621)
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2623),
                            Description = "CÔNG TY CỔ PHẦN QUỐC TẾ MBA",
                            Name = "Title",
                            SectionId = 3,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2623)
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2625),
                            Description = "Công ty CP Quốc tế MBA là nhà sản xuất và phân phối hàng đầu các giải pháp toàn diện cho ngành Giáo Dục – Y Tế - Công Nghệ Cao. Với hơn 17 năm kinh nghiệm, MBA tự hào với đội ngũ nhân viên giàu kinh nghiệm, nhiệt huyết và chuyên nghiệp, luôn mang đến cho khách hàng những trải nghiệm tốt nhất về sản phẩm và dịch vụ chính hãng. Với  xu hướng phát triển không ngừng của ngành khoa học thông tin và cách mạng công nghiệp 4.0, nhằm đáp ứng nhu cầu ngày càng cao của khách hàng trong việc trang bị các thiết bị điện tử và các giải pháp công nghệ, Công Ty Cổ Phần Quốc Tế MBA đã mang đến cho Quý khách hàng những sản phẩm hiện đại nhất của các hãng nổi tiếng trên thị trường Bên cạnh đó ngoài chức năng phân phối, MBA cũng là đại diện bảo hành, bảo trì, sữa chữa và thực hiện các dịch vụ sau bán hàng của các đối tác nói trên nhằm cung cấp giải pháp toàn diện, hiệu quả cho khách hàng khi sử dụng sản phẩm MBA phân phối với đội kỹ thuật viên giàu kinh nghiệm, linh kiện thay thế chính hãng và giá cả hợp lý.",
                            Name = "Detail",
                            SectionId = 3,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2624)
                        },
                        new
                        {
                            Id = 7,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2628),
                            Description = "TẦM NHÌN - SỨ MỆNH\r\nMBA INTERNATIONAL JSC",
                            Name = "Big Title",
                            SectionId = 4,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2626)
                        },
                        new
                        {
                            Id = 8,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2629),
                            Description = "Tầm nhìn thương hiệu",
                            Name = "Title",
                            SectionId = 4,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2628)
                        },
                        new
                        {
                            Id = 9,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2631),
                            Description = "MBA International Corporation luôn hướng tới mục tiêu duy trì vị trí thương hiệu hàng đầu tại Việt Nam trong lĩnh vực phân phối các Thiết bị Giáo dục – Y tế – Công nghệ cao.",
                            Name = "Detail",
                            SectionId = 4,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2630)
                        },
                        new
                        {
                            Id = 10,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2633),
                            Description = "Sứ mệnh",
                            Name = "Title2",
                            SectionId = 4,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2632)
                        },
                        new
                        {
                            Id = 11,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2635),
                            Description = "Với tôn chỉ \" Let's Grow Together! - Cùng đến thành công !\", Công ty CP Quốc Tế MBA luôn hướng tới sự phát triển bền vững không chỉ cho doanh nghiệp mà còn cho cộng đồng bằng cam kết mang những sản phẩm ngành Giáo Dục - Y Tế - Công Nghệ Cao chất lượng hàng đầu Thế giới với giá cả cạnh tranh nhất đến đông đảo Quý khách hàng.",
                            Name = "Title2",
                            SectionId = 4,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2634)
                        },
                        new
                        {
                            Id = 12,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2636),
                            Description = "LỊCH SỬ HÌNH THÀNH\r\nMBA INTERNATIONAL JSC",
                            Name = "Big Title",
                            SectionId = 5,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2635)
                        },
                        new
                        {
                            Id = 13,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2638),
                            Description = "BAN LÃNH ĐẠO\r\nMBA INTERNATIONAL JSC",
                            Name = "Big Title",
                            SectionId = 6,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2637)
                        });
                });

            modelBuilder.Entity("Core.Models.Entity.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Image", (string)null);
                });

            modelBuilder.Entity("Core.Models.Entity.LeaderShip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LeaderShip", (string)null);
                });

            modelBuilder.Entity("Core.Models.Entity.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Page", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2461),
                            Name = "Home",
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2455),
                            Url = "/"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2464),
                            Name = "Introduction",
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2463),
                            Url = "/introduction"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2466),
                            Name = "Product",
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2465),
                            Url = "/product"
                        });
                });

            modelBuilder.Entity("Core.Models.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("Core.Models.Entity.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Specifications")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetail", (string)null);
                });

            modelBuilder.Entity("Core.Models.Entity.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ButtonUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("PageId")
                        .HasColumnType("int");

                    b.Property<int?>("SectionParentId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.HasIndex("SectionParentId");

                    b.ToTable("Section", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2588),
                            Name = "Home",
                            PageId = 1,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2586)
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2590),
                            Name = "Introduction",
                            PageId = 2,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2589)
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2592),
                            Name = "About",
                            SectionParentId = 2,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2591)
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2594),
                            Name = "Vision",
                            SectionParentId = 2,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2593)
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2595),
                            Name = "History",
                            SectionParentId = 2,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2595)
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2597),
                            Name = "Leadership",
                            SectionParentId = 2,
                            UpdatedDate = new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2596)
                        });
                });

            modelBuilder.Entity("Core.Models.Entity.Describe", b =>
                {
                    b.HasOne("Core.Models.Entity.Section", "Section")
                        .WithMany("Describes")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("Core.Models.Entity.Image", b =>
                {
                    b.HasOne("Core.Models.Entity.Section", "Section")
                        .WithMany("Images")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("Core.Models.Entity.ProductDetail", b =>
                {
                    b.HasOne("Core.Models.Entity.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Models.Entity.Section", b =>
                {
                    b.HasOne("Core.Models.Entity.Page", "Page")
                        .WithMany("Sections")
                        .HasForeignKey("PageId");

                    b.HasOne("Core.Models.Entity.Section", "SectionParent")
                        .WithMany("Sections")
                        .HasForeignKey("SectionParentId");

                    b.Navigation("Page");

                    b.Navigation("SectionParent");
                });

            modelBuilder.Entity("Core.Models.Entity.Page", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Core.Models.Entity.Product", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("Core.Models.Entity.Section", b =>
                {
                    b.Navigation("Describes");

                    b.Navigation("Images");

                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}