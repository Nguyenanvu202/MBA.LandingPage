using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "Specifications",
                table: "ProductDetail",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductDetail",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(818), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(832), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(834), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(837), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(841), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(886), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(888), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(892), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(913), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(915), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(916), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(918), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(920), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(666), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(668), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ImageUrl", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(938), "/image/Product/product1.jpg", "CÔNG NGHỆ CAO", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(936) },
                    { 2, "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(940), "/image/Product/product2.jpg", "THIẾT BỊ Y TẾ", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(939) },
                    { 3, "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(942), "/image/Product/product3.jpg", "THIẾT BỊ GIÁO DỤC", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(941) }
                });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(788), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(790), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(792), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(796), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.InsertData(
                table: "ProductDetail",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "Name", "ProductId", "Specifications", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "167", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(961), null, "/image/Product/moredetail/product1.jpg", "CÔNG NGHỆ THÔNG TIN", 1, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(954) },
                    { 2, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(964), null, "/image/Product/moredetail/product2.jpg", "CÔNG NGHỆ SINH HỌC", 1, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(962) },
                    { 3, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(966), null, "/image/Product/moredetail/product3.jpg", "CÔNG NGHỆ VẬT LIỆU MỚI", 1, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(965) },
                    { 4, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(969), null, "/image/Product/moredetail/product4.jpg", "CÔNG NGHỆ TỰ ĐỘNG HOÁ", 1, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(967) },
                    { 5, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(971), null, "/image/Product/moredetail/product4.jpg", "HỆ THỐNG PHÒNG TAI MŨI HỌNG", 2, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(970) },
                    { 6, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(973), null, "/image/Product/moredetail/product4.jpg", "HỆ THỐNG PHÒNG CHUẨN ĐOÁN", 2, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(972) },
                    { 7, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(976), null, "/image/Product/moredetail/product4.jpg", "HỆ THỐNG PHÒNG CHỤP CT", 2, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(974) },
                    { 8, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(978), null, "/image/Product/moredetail/product4.jpg", "HỆ THỐNG PHÒNG CHỤP PHẪU THUẬT", 2, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(977) },
                    { 9, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(980), null, "/image/Product/moredetail/product4.jpg", "PHÒNG HỌC BỘ MÔN HOÁ", 3, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(979) },
                    { 10, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(982), null, "/image/Product/moredetail/product4.jpg", "PHÒNG HỌC BỘ MÔN LÝ", 3, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(981) },
                    { 11, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(985), null, "/image/Product/moredetail/product4.jpg", "PHÒNG HỌC TIN HỌC", 3, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(983) },
                    { 12, "166", "Admin", new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(987), null, "/image/Product/moredetail/product4.jpg", "PHÒNG HỌC BỘ MÔN SINH", 3, null, "Còn Hàng", null, new DateTime(2024, 4, 5, 19, 46, 44, 143, DateTimeKind.Local).AddTicks(986) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Specifications",
                table: "ProductDetail",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductDetail",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "ProductDetail",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Product",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5534), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5536), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5541), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5543), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5545), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5547), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5549), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5553), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5554), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5558), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5586), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5590), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5592), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5616), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5621), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5315), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5320), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5497), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5501), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5504), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5507), new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5506) });
        }
    }
}
