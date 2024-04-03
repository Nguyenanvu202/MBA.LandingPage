using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataOfInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Image",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5534), "VỀ CÔNG TY", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5531) });

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
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5547), "TẦM NHÌN - SỨ MỆNH", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5546) });

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
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5556), "LỊCH SỬ HÌNH THÀNH", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5558), "BAN LÃNH ĐẠO", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "SectionId", "UpdatedBy", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5584), null, 1, null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5581), "/image/index/bg1.jpg" },
                    { 2, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5586), null, 3, null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5585), "/image/Information/ceo.jpg" },
                    { 3, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5588), "Image 1", 4, null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5587), "/image/Information/vision1.jpg" },
                    { 4, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5590), "Image 2", 4, null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5589), "/image/Information/vision2.jpg" },
                    { 5, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5592), null, 5, null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5591), "/image/Information/history.jpg" }
                });

            migrationBuilder.InsertData(
                table: "LeaderShip",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ImageUrl", "Name", "Position", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5612), "/image/Information/ceo1.jpg", "MR NGUYỄN TRÍ ĐĂNG", "TRỢ LÝ TỔNG GIÁM ĐỐC", null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5610) },
                    { 2, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5614), "/image/Information/ceo2.jpg", "MR NGUYỄN TRÍ ĐĂNG", "TRỢ LÝ TỔNG GIÁM ĐỐC", null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5613) },
                    { 3, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5616), "/image/Information/ceo3.jpg", "MR NGUYỄN TRÍ ĐĂNG", "TRỢ LÝ TỔNG GIÁM ĐỐC", null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5615) },
                    { 4, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5619), "/image/Information/ceo4.jpg", "MR NGUYỄN TRÍ ĐĂNG", "TRỢ LÝ TỔNG GIÁM ĐỐC", null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5618) },
                    { 5, "Admin", new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5621), "/image/Information/ceo5.jpg", "MR NGUYỄN TRÍ ĐĂNG", "TRỢ LÝ TỔNG GIÁM ĐỐC", null, new DateTime(2024, 4, 3, 18, 34, 49, 91, DateTimeKind.Local).AddTicks(5620) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LeaderShip",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Image");

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2616), "VỀ CÔNG TY\r\nMBA INTERNATIONAL JSC", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2618), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2622), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2623), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2625), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2628), "TẦM NHÌN - SỨ MỆNH\r\nMBA INTERNATIONAL JSC", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2629), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2631), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2635), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2636), "LỊCH SỬ HÌNH THÀNH\r\nMBA INTERNATIONAL JSC", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2638), "BAN LÃNH ĐẠO\r\nMBA INTERNATIONAL JSC", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2461), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2464), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2466), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2588), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2590), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2594), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2595), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2596) });
        }
    }
}
