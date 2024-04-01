using Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Repository
{
    public interface ISectionRepo
    {
        Task<List<Section>> GetAllParentSection(int PageId);
        Task<Section> GetParentSectionById(int PageId, int Id);
        Task<Section> UpdateParentSection(int PageId, int Id, Section section);
        Task<Section> CreateParentSection(int PageId, Section section);
        Task<Section> DeleteParentSection(int PageId, int Id);


        Task<List<Section>> GetAllSection(int PSectionId);
        Task<Section> GetSectionById(int PSectionId, int Id);
        Task<Section> UpdateSection(int PSectionId, int Id, Section section);
        Task<Section> CreateSection(int PSectionId, Section section);
        Task<Section> DeleteSection(int PSectionId, int Id);
    }
}
