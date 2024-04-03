using Core.Models.Entity;
using Core.Models.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Infrastructure.Data.Repository
{
    public class DescribeRepo : IDescribeRepo
    {
        private readonly MBAContext _mbaContext;

        public DescribeRepo(MBAContext mbaContext)
        {
            _mbaContext = mbaContext;
        }

        public async Task<Describe> CreateDescribe(int SectionId, Describe describe)
        {
            List<Describe> describes = new List<Describe>();
            describes = await _mbaContext.Describes.Where(s => s.SectionId == SectionId).ToListAsync();
            describes.Add(describe);
            await _mbaContext.SaveChangesAsync();
            return describe;
        }

        public async Task<Describe> DeleteDescribe(int SectionId, int Id)
        {
            var exsitDescribe = await _mbaContext.Describes
                .Where(s => s.SectionId == SectionId)
                .FirstOrDefaultAsync(i => i.Id == Id);
            _mbaContext.Describes.Remove(exsitDescribe);
            await _mbaContext.SaveChangesAsync();
            return exsitDescribe;
        }

        public List<Describe> GetAllDescribeAsync(int SectionId)
        {
            return _mbaContext.Describes.Where(s => s.SectionId == SectionId).ToList();
        }

        public List<Describe> GetAllDescribe(int SectionId)
        {
            var describe = _mbaContext.Describes.Where(s => s.SectionId == SectionId).ToList();
            return describe;
        }

        public async Task<Describe> GetDescribeBySectionId(int SectionId, int Id)
        {
            return await _mbaContext.Describes.Where(s => s.SectionId == SectionId).FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<Describe> UpdateDescribe(int SectionId, int Id, Describe describe)
        {
            var exsitDescribe = await _mbaContext.Describes
                .Where(s => s.SectionId == SectionId)
                .FirstOrDefaultAsync(i => i.Id == Id);
            exsitDescribe.Name = describe.Name;
            exsitDescribe.Description = describe.Description;
            await _mbaContext.SaveChangesAsync();
            return exsitDescribe;
        }


    }
}
