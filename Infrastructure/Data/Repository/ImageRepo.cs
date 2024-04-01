using Core.Models.Entity;
using Core.Models.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repository
{
    public class ImageRepo : IImageRepo
    {
        private readonly MBAContext _mbaContext;

        public ImageRepo(MBAContext mbaContext)
        {
            _mbaContext = mbaContext;
        }

        public async Task<Image> CreateImage(int SectionId, Image image)
        {
            List<Image> describes = new List<Image>();
            describes = await _mbaContext.Images.Where(s => s.SectionId == SectionId).ToListAsync();
            describes.Add(image);
            await _mbaContext.SaveChangesAsync();
            return image;
        }

        public async Task<Image> DeleteImage(int SectionId, int Id)
        {
            var exsitImage = await _mbaContext.Images
                .Where(s => s.SectionId == SectionId)
                .FirstOrDefaultAsync(i => i.Id == Id);
            _mbaContext.Images.Remove(exsitImage);
            await _mbaContext.SaveChangesAsync();
            return exsitImage;
        }

        public async Task<List<Image>> GetAllImage(int SectionId)
        {
            return await _mbaContext.Images.Where(s => s.SectionId == SectionId).ToListAsync();
        }


        public async Task<Image> GetImageBySectionId(int SectionId, int Id)
        {
            return await _mbaContext.Images.Where(s => s.SectionId == SectionId).FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<Image> UpdateImage(int SectionId, int Id, Image image)
        {
            var exsitImage = await _mbaContext.Images
                .Where(s => s.SectionId == SectionId)
                .FirstOrDefaultAsync(i => i.Id == Id);
            exsitImage.Url = image.Url;
            await _mbaContext.SaveChangesAsync();
            return exsitImage;
        }
    }
}
