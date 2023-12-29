using Application.Wrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrapper.Concrete
{
    public class Response : IResponse
    {
        public bool Success {  get; }

        public int StatusCode { get; }

        public Response(bool success, int statusCode)
        {
            Success = success;
            StatusCode = statusCode;
        }

        public Response(bool success)
        {
            Success = success;
        }
    }
}
