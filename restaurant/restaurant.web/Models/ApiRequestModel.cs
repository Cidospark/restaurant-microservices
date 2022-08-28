using System;
using static restaurant.web.SD;

namespace restaurant.web.Models
{
    public class ApiRequestModel
    {
        public ApiType ApiType { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
