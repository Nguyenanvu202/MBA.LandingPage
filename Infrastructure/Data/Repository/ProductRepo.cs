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
    public class ProductRepo : IProductRepo
    {
        private readonly MBAContext _mbaContext;

        public ProductRepo(MBAContext mBAContext)
        {
            _mbaContext = mBAContext;
        }
        public Task<Product> CreateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> DeleteProductAsync(int Id)
        {
            var existProduct = await _mbaContext.Products.FirstOrDefaultAsync(i => i.Id == Id);
            _mbaContext.Products.Remove(existProduct);
            await _mbaContext.SaveChangesAsync();
            return existProduct;
        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            return await _mbaContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int Id)
        {
            return await _mbaContext.Products.FirstOrDefaultAsync(i => i.Id == Id);
        }
    }
}
