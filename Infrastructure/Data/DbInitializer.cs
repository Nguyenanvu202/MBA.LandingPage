using Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
	public class DbInitializer
	{
		private readonly ModelBuilder modelBuilder;

		public DbInitializer(ModelBuilder modelBuilder)
        {
			this.modelBuilder = modelBuilder;
		}

		public void Seed()
		{
			modelBuilder.Entity<Page>().HasData(
				new Page() {Id = 1,Name = "Home", Url="/", CreatedBy = "Admin", CreatedDate = DateTime.Now},
				new Page() {Id = 2,Name = "Introduction", Url="/introduction", CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Page() {Id = 3,Name = "Product", Url="/product", CreatedBy = "Admin", CreatedDate = DateTime.Now }
				);

			modelBuilder.Entity<Section>().HasData(
				new Section() { Id = 1, Name = "Home", PageId = 1, CreatedBy = "Admin", CreatedDate = DateTime.Now },

				new Section() { Id = 2, Name = "Introduction", PageId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Section() { Id = 3, Name = "About", SectionParentId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Section() { Id = 4, Name = "Vision", SectionParentId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Section() {Id = 5, Name = "History", SectionParentId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Section() {Id = 6, Name = "Leadership", SectionParentId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now }

				);

			modelBuilder.Entity<Describe>().HasData(
				new Describe() { Id = 1, Name = "Big Title", Description = "VỀ CÔNG TY", SectionId = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() { Id = 2, Name = "General Manager", Description = "Tổng Giám đốc - Người sáng lập MBA", SectionId = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() { Id = 3, Name = "Slogan", Description = "Let’s Grow Together!\r\nCùng đến thành công!", SectionId = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() { Id = 4, Name = "Tag", Description = "MBA International JSC", SectionId = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() { Id = 5, Name = "Title", Description = "CÔNG TY CỔ PHẦN QUỐC TẾ MBA", SectionId = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() { Id = 6, Name = "Detail", Description = "Công ty CP Quốc tế MBA là nhà sản xuất và phân phối hàng đầu các giải pháp toàn diện cho ngành Giáo Dục – Y Tế - Công Nghệ Cao. Với hơn 17 năm kinh nghiệm, MBA tự hào với đội ngũ nhân viên giàu kinh nghiệm, nhiệt huyết và chuyên nghiệp, luôn mang đến cho khách hàng những trải nghiệm tốt nhất về sản phẩm và dịch vụ chính hãng. Với  xu hướng phát triển không ngừng của ngành khoa học thông tin và cách mạng công nghiệp 4.0, nhằm đáp ứng nhu cầu ngày càng cao của khách hàng trong việc trang bị các thiết bị điện tử và các giải pháp công nghệ, Công Ty Cổ Phần Quốc Tế MBA đã mang đến cho Quý khách hàng những sản phẩm hiện đại nhất của các hãng nổi tiếng trên thị trường" +
				" Bên cạnh đó ngoài chức năng phân phối, MBA cũng là đại diện bảo hành, bảo trì, sữa chữa và thực hiện các dịch vụ sau bán hàng của các đối tác nói trên nhằm cung cấp giải pháp toàn diện, hiệu quả cho khách hàng khi sử dụng sản phẩm MBA phân phối với đội kỹ thuật viên giàu kinh nghiệm, linh kiện thay thế chính hãng và giá cả hợp lý.", SectionId = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now},


				new Describe() { Id = 7, Name = "Big Title", Description = "TẦM NHÌN - SỨ MỆNH", SectionId = 4, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() { Id = 8, Name = "Title", Description = "Tầm nhìn thương hiệu", SectionId = 4, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() { Id = 9, Name = "Detail", Description = "MBA International Corporation luôn hướng tới mục tiêu duy trì vị trí thương hiệu hàng đầu tại Việt Nam trong lĩnh vực phân phối các Thiết bị Giáo dục – Y tế – Công nghệ cao.", SectionId = 4, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() { Id = 10, Name = "Title2", Description = "Sứ mệnh", SectionId = 4, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() { Id = 11, Name = "Title2", Description = "Với tôn chỉ \" Let's Grow Together! - Cùng đến thành công !\", Công ty CP Quốc Tế MBA luôn hướng tới sự phát triển bền vững không chỉ cho doanh nghiệp mà còn cho cộng đồng bằng cam kết mang những sản phẩm ngành Giáo Dục - Y Tế - Công Nghệ Cao chất lượng hàng đầu Thế giới với giá cả cạnh tranh nhất đến đông đảo Quý khách hàng.", SectionId = 4, CreatedBy = "Admin", CreatedDate = DateTime.Now },

				new Describe() { Id = 12, Name = "Big Title", Description = "LỊCH SỬ HÌNH THÀNH", SectionId = 5, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Describe() {Id = 13, Name = "Big Title", Description = "BAN LÃNH ĐẠO", SectionId = 6, CreatedBy = "Admin", CreatedDate = DateTime.Now }
				);
			modelBuilder.Entity<Image>().HasData(
				new Image() { Id = 1, Url = "/image/index/bg1.jpg", SectionId = 1, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Image() { Id = 2, Url = "/image/Information/ceo.jpg", SectionId = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Image() { Id = 3, Url = "/image/Information/vision1.jpg", SectionId = 4,Name = "Image 1" ,CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Image() { Id = 4, Url = "/image/Information/vision2.jpg", SectionId = 4, Name = "Image 2", CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new Image() { Id = 5, Url = "/image/Information/history.jpg", SectionId = 5, CreatedBy = "Admin", CreatedDate = DateTime.Now }
				);

			modelBuilder.Entity<LeaderShip>().HasData(

				new LeaderShip() { Id = 1, ImageUrl = "/image/Information/ceo1.jpg", Name = "MR NGUYỄN TRÍ ĐĂNG", Position = "TRỢ LÝ TỔNG GIÁM ĐỐC", CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new LeaderShip() { Id = 2, ImageUrl = "/image/Information/ceo2.jpg", Name = "MR NGUYỄN TRÍ ĐĂNG", Position = "TRỢ LÝ TỔNG GIÁM ĐỐC", CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new LeaderShip() { Id = 3, ImageUrl = "/image/Information/ceo3.jpg", Name = "MR NGUYỄN TRÍ ĐĂNG", Position = "TRỢ LÝ TỔNG GIÁM ĐỐC", CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new LeaderShip() { Id = 4, ImageUrl = "/image/Information/ceo4.jpg", Name = "MR NGUYỄN TRÍ ĐĂNG", Position = "TRỢ LÝ TỔNG GIÁM ĐỐC", CreatedBy = "Admin", CreatedDate = DateTime.Now },
				new LeaderShip() { Id = 5, ImageUrl = "/image/Information/ceo5.jpg", Name = "MR NGUYỄN TRÍ ĐĂNG", Position = "TRỢ LÝ TỔNG GIÁM ĐỐC", CreatedBy = "Admin", CreatedDate = DateTime.Now }
				);
		}
    }
}
