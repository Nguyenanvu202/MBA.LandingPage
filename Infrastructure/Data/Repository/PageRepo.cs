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
    public class PageRepo : IPageRepo
    {
        private readonly MBAContext _mbaContext;

        public PageRepo(MBAContext mBAContext)
        {
            _mbaContext = mBAContext;
        }
        public Task<Page> CreatePage(Page Page)
        {
            throw new NotImplementedException();
        }

        public async Task<Page> DeletePage(int Id)
        {
            var existPage = await _mbaContext.Pages.FirstOrDefaultAsync(i => i.Id == Id);
             _mbaContext.Pages.Remove(existPage);
            await _mbaContext.SaveChangesAsync();
            return existPage;
        }

        public async Task<List<Page>> GetAllPage()
        {
            return await _mbaContext.Pages.ToListAsync();
        }

        public async Task<Page> GetPageById(int Id)
        {
            return await _mbaContext.Pages.FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<Page> UpdatePage(int Id, Page Page)
        {
            var existPage = await _mbaContext.Pages.FirstOrDefaultAsync(i => i.Id == Id);
            existPage.Name = Page.Name;
            existPage.Url = Page.Url;
            await _mbaContext.SaveChangesAsync();
            return existPage;
        }
    }
}
