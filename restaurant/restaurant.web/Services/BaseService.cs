using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using restaurant.web.Models;
using restaurant.web.Services.IService;

namespace restaurant.web.Services
{
    public class BaseService : IBaseService
    { 
        public ResponseDto _ResponseModel { get; set; }
        public IHttpClientFactory _HttpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            _HttpClient = httpClient;
            _ResponseModel = new ResponseDto();
        }

        public async Task<T> SendAsync<T>(ApiRequestModel apiRequestModel)
        {
            try
            {
                var client = _HttpClient.CreateClient("restaurantAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequestModel.Url);
                client.DefaultRequestHeaders.Clear();
                if(apiRequestModel.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequestModel.Data),
                        Encoding.UTF8, "application/json");
                }
                HttpResponseMessage apiResponse = null;
                switch (apiRequestModel.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;

                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;

                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;

                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                apiResponse = await client.SendAsync(message);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();

                var apiResponseDto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseDto;

            }catch(Exception e)
            {
                var dto = new ResponseDto
                {
                    DisplayMessage = "Error",
                    ErrorMessages = new List<string> { Convert.ToString(e.Message) },
                    IsSuccess = false
                };
                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDto = JsonConvert.DeserializeObject<T>(res);
                return apiResponseDto;
            }
        }


        public void Dispose()
        {
            GC.SuppressFinalize(true);
        } 
    }
}
