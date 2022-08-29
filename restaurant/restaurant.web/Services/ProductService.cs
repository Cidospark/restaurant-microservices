using System;
using System.Net.Http;
using System.Threading.Tasks;
using restaurant.web.Models;
using restaurant.web.Services.IService;

namespace restaurant.web.Services
{
    public class ProductService : BaseService,IProductServices
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _clientFactory = httpClientFactory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequestModel()
            {
                ApiType = SD.ApiType.POST,
                Data = productDto,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequestModel()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.ProductAPIBase + "/api/products" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequestModel()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = ""
            });
        }

        public async Task<T> GetAProductByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequestModel()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/products" + id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateProductAysnc<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequestModel()
            {
                ApiType = SD.ApiType.PUT,
                Data = productDto,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = ""
            });
        }
    }
}
