using System;
using System.Threading.Tasks;
using restaurant.web.Models;

namespace restaurant.web.Services.IService
{
    public interface IBaseService : IDisposable
    {
        ResponseDto _ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequestModel apiRequestModel);
    }
}
