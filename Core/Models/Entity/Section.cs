using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Entity
{
    public class Section : BaseEntity
    {
        public int Id { get; set; }
        public string? ButtonUrl { get; set; }
        public string Name { get; set; }

        public int? PageId { get; set; }
        public virtual Page? Page { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Describe> Describes { get; set; }

        public int? SectionParentId { get; set; }
        public virtual Section? SectionParent { get; set; }
        public virtual ICollection<Section>? Sections { get; set; }
    }
}
