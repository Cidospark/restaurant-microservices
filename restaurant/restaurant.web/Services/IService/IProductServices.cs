using System;
using System.Threading.Tasks;
using restaurant.web.Models;

namespace restaurant.web.Services.IService
{
    public interface IProductServices
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetAProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAysnc<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
