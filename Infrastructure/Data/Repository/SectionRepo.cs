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
    public class SectionRepo : ISectionRepo
    {
        private readonly MBAContext _mbaContext;

        public SectionRepo(MBAContext mbaContext)
        {
            _mbaContext = mbaContext;
        }

        public async Task<Section> CreateParentSection(int PageId, Section section)
        {
            List<Section> sections = new List<Section>();
            sections = await _mbaContext.Sections.Where(p => p.Id == PageId).ToListAsync();
            sections.Add(section);
            return section;
        }

        public async Task<Section> DeleteParentSection(int PageId, int Id)
        {
            var existSection = await _mbaContext.Sections
                .Where(p => p.Id == PageId)
                .FirstOrDefaultAsync(i => i.Id == Id);
            _mbaContext.Sections.Remove(existSection);
            return existSection;
        }

        public async Task<List<Section>> GetAllParentSection(int PageId)
        {
            return await _mbaContext.Sections.Where(p => p.Id == PageId).ToListAsync();

        }

        public async Task<Section> GetParentSectionById(int PageId, int Id)
        {
            return await _mbaContext.Sections
                .Where(p => p.Id == PageId)
                .FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<Section> UpdateParentSection(int PageId, int Id, Section section)
        {
            var existSection = await _mbaContext.Sections
                .Where(p => p.Id == PageId)
                .FirstOrDefaultAsync(i => i.Id == Id);
            existSection.ButtonUrl = section.ButtonUrl;
            await _mbaContext.SaveChangesAsync();
            return existSection;
        }

        //Section
        public async Task<Section> CreateSection(int PSectionId, Section section)
        {
            List<Section> sections = new List<Section>();
            sections = await _mbaContext.Sections.Where(p => p.SectionParentId == PSectionId).ToListAsync();
            sections.Add(section);
            return section;
        }

        public async Task<Section> DeleteSection(int PSectionId, int Id)
        {
            var existSection = await _mbaContext.Sections
                .Where(p => p.SectionParentId == PSectionId)
                .FirstOrDefaultAsync(i => i.Id == Id);
            _mbaContext.Sections.Remove(existSection);
            return existSection;
        }

        public async Task<List<Section>> GetAllSection(int PSectionId)
        {
            return await _mbaContext.Sections.Where(p => p.SectionParentId == PSectionId).ToListAsync();
        }

        public async Task<Section> GetSectionById(int PSectionId, int Id)
        {
            return await _mbaContext.Sections
                .Where(p => p.SectionParentId == PSectionId).Include(d => d.Describes).Include(i => i.Images)
                .FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<Section> UpdateSection(int PSectionId, int Id, Section section)
        {
            var existSection = await _mbaContext.Sections
                .Where(p => p.SectionParentId == PSectionId)
                .FirstOrDefaultAsync(i => i.Id == Id);
            existSection.ButtonUrl = section.ButtonUrl;
            await _mbaContext.SaveChangesAsync();
            return existSection;
        }

    }
}
