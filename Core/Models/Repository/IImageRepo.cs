using Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Repository
{
    public interface IImageRepo
    {
        List<Image> GetAllImage(int SectionId);
        Task<Image> UpdateImage(int SectionId, int Id, Image Describe);
        Task<Image> CreateImage(int SectionId, Image Describe);
        Task<Image> DeleteImage(int SectionId, int Id);
    }
}
