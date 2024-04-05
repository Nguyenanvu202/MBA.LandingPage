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
    public class ProductDetailRepo : IProductDetailRepo
    {
        private readonly MBAContext _mbaContext;

        public ProductDetailRepo(MBAContext mbaContext)
        {
            _mbaContext = mbaContext;
        }
        public Task<ProductDetail> CreateProductDetailAsync(ProductDetail productDetail)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDetail> DeleteProductDetailAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductDetail>> GetAllProductDetailAsync(int ProductId)
        {
            return await _mbaContext.ProductDetails.Where(i => i.ProductId == ProductId).ToListAsync();
        }

        public async Task<ProductDetail> GetProductDetailByIdAsync(int Id)
        {
            return await _mbaContext.ProductDetails.FirstOrDefaultAsync(i => i.Id == Id);
        }
    }
}
