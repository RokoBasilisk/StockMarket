using Application.Wrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Wrapper.Concrete
{
    public class DataResponse<T> : IDataResponse<T>
    {
        public T Data { get; }

        public string Message { get; set; }

        public bool Success { get; } = true;

        public int StatusCode { get; }

        [JsonConstructor]
        public DataResponse(T data, int statusCode)
        {
            Data = data;
            StatusCode = statusCode;
        }

        public DataResponse(T data, int statusCode, string message)
        {
            Data = data;
            StatusCode = statusCode;
            Message = message;
        }
    }
}
