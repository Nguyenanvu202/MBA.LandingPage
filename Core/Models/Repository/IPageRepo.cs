using Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Repository
{
    public interface IPageRepo
    {
        Task<List<Page>> GetAllPage();
        Task<Page> GetPageById(int Id);
        Task<Page> UpdatePage(int Id, Page Page);
        Task<Page> CreatePage(Page Page);
        Task<Page> DeletePage(int Id);
    }
}
