using Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Repository
{
    public interface IProductRepo
    {
        Task<List<Product>> GetAllProductAsync();
        Task<Product> GetProductByIdAsync(int Id);
       /* Task<Product> UpdateProductAsync(int Id, Product product);*/
        Task<Product> CreateProductAsync(Product product);
        Task<Product> DeleteProductAsync(int Id);
    }
}
