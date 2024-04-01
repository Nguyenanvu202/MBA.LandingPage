using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Page_PageId",
                table: "Section");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Section",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Section",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PageId",
                table: "Section",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Section",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ButtonUrl",
                table: "Section",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Section",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Page",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Page",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Page",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Image",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Image",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Image",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Describe",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Describe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Describe",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Describe",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "LeaderShip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaderShip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Specifications = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2461), "Home", null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2455), "/" },
                    { 2, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2464), "Introduction", null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2463), "/introduction" },
                    { 3, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2466), "Product", null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2465), "/product" }
                });

            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "Id", "ButtonUrl", "CreatedBy", "CreatedDate", "Name", "PageId", "SectionParentId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2588), "Home", 1, null, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2586) },
                    { 2, null, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2590), "Introduction", 2, null, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2589) },
                    { 3, null, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2592), "About", null, 2, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2591) },
                    { 4, null, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2594), "Vision", null, 2, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2593) },
                    { 5, null, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2595), "History", null, 2, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2595) },
                    { 6, null, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2597), "Leadership", null, 2, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2596) }
                });

            migrationBuilder.InsertData(
                table: "Describe",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "SectionId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2616), "VỀ CÔNG TY\r\nMBA INTERNATIONAL JSC", "Big Title", 3, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2614) },
                    { 2, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2618), "Tổng Giám đốc - Người sáng lập MBA", "General Manager", 3, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2617) },
                    { 3, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2620), "Let’s Grow Together!\r\nCùng đến thành công!", "Slogan", 3, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2619) },
                    { 4, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2622), "MBA International JSC", "Tag", 3, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2621) },
                    { 5, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2623), "CÔNG TY CỔ PHẦN QUỐC TẾ MBA", "Title", 3, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2623) },
                    { 6, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2625), "Công ty CP Quốc tế MBA là nhà sản xuất và phân phối hàng đầu các giải pháp toàn diện cho ngành Giáo Dục – Y Tế - Công Nghệ Cao. Với hơn 17 năm kinh nghiệm, MBA tự hào với đội ngũ nhân viên giàu kinh nghiệm, nhiệt huyết và chuyên nghiệp, luôn mang đến cho khách hàng những trải nghiệm tốt nhất về sản phẩm và dịch vụ chính hãng. Với  xu hướng phát triển không ngừng của ngành khoa học thông tin và cách mạng công nghiệp 4.0, nhằm đáp ứng nhu cầu ngày càng cao của khách hàng trong việc trang bị các thiết bị điện tử và các giải pháp công nghệ, Công Ty Cổ Phần Quốc Tế MBA đã mang đến cho Quý khách hàng những sản phẩm hiện đại nhất của các hãng nổi tiếng trên thị trường Bên cạnh đó ngoài chức năng phân phối, MBA cũng là đại diện bảo hành, bảo trì, sữa chữa và thực hiện các dịch vụ sau bán hàng của các đối tác nói trên nhằm cung cấp giải pháp toàn diện, hiệu quả cho khách hàng khi sử dụng sản phẩm MBA phân phối với đội kỹ thuật viên giàu kinh nghiệm, linh kiện thay thế chính hãng và giá cả hợp lý.", "Detail", 3, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2624) },
                    { 7, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2628), "TẦM NHÌN - SỨ MỆNH\r\nMBA INTERNATIONAL JSC", "Big Title", 4, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2626) },
                    { 8, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2629), "Tầm nhìn thương hiệu", "Title", 4, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2628) },
                    { 9, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2631), "MBA International Corporation luôn hướng tới mục tiêu duy trì vị trí thương hiệu hàng đầu tại Việt Nam trong lĩnh vực phân phối các Thiết bị Giáo dục – Y tế – Công nghệ cao.", "Detail", 4, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2630) },
                    { 10, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2633), "Sứ mệnh", "Title2", 4, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2632) },
                    { 11, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2635), "Với tôn chỉ \" Let's Grow Together! - Cùng đến thành công !\", Công ty CP Quốc Tế MBA luôn hướng tới sự phát triển bền vững không chỉ cho doanh nghiệp mà còn cho cộng đồng bằng cam kết mang những sản phẩm ngành Giáo Dục - Y Tế - Công Nghệ Cao chất lượng hàng đầu Thế giới với giá cả cạnh tranh nhất đến đông đảo Quý khách hàng.", "Title2", 4, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2634) },
                    { 12, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2636), "LỊCH SỬ HÌNH THÀNH\r\nMBA INTERNATIONAL JSC", "Big Title", 5, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2635) },
                    { 13, "Admin", new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2638), "BAN LÃNH ĐẠO\r\nMBA INTERNATIONAL JSC", "Big Title", 6, null, new DateTime(2024, 4, 1, 16, 39, 47, 354, DateTimeKind.Local).AddTicks(2637) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductId",
                table: "ProductDetail",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Page_PageId",
                table: "Section",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Page_PageId",
                table: "Section");

            migrationBuilder.DropTable(
                name: "LeaderShip");

            migrationBuilder.DropTable(
                name: "ProductDetail");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Describe",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Section");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Section",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Section",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PageId",
                table: "Section",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Section",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "ButtonUrl",
                table: "Section",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Page",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Page",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Page",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Image",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Image",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Image",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Describe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Describe",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Describe",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Describe",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Page_PageId",
                table: "Section",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
