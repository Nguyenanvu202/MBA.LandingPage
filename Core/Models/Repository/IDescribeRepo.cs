using Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Repository
{
    public interface IDescribeRepo
    {
        Task<List<Describe>> GetAllDescribe(int SectionId);
        Task<Describe> GetDescribeBySectionId(int SectionId,int Id);
        Task<Describe> UpdateDescribe(int SectionId, int Id, Describe describe);
        Task<Describe> CreateDescribe(int SectionId, Describe describe);
        Task<Describe> DeleteDescribe(int SectionId, int Id);
    }
}
