using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Entity
{
    public class Image : BaseEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public int SectionId { get; set; }
        public virtual Section Section { get; set; }
    }
}
