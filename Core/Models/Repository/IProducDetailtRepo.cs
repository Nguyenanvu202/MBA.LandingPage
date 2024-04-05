using Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Repository
{
    public interface IProductDetailRepo
    {
        Task<List<ProductDetail>> GetAllProductDetailAsync(int ProductId);
        Task<ProductDetail> GetProductDetailByIdAsync(int Id);
       /* Task<Product> UpdateProductAsync(int Id, Product product);*/
        Task<ProductDetail> CreateProductDetailAsync(ProductDetail productDetail);
        Task<ProductDetail> DeleteProductDetailAsync(int Id);
    }
}
