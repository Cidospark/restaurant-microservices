using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using restaurant.ProductAPI.Models.Dtos;

namespace restaurant.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
