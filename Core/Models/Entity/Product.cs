using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Entity
{
	public class Product : BaseEntity
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
		public string Url { get; set; }

		public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
