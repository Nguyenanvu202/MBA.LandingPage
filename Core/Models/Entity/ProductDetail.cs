using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Entity
{
	public class ProductDetail : BaseEntity
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Specifications { get; set; }
        public string Url { get; set; }

        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
