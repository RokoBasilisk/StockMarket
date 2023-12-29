using Application.Wrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrapper.Concrete
{
    public class SuccessResponse : ISuccessResponse
    {
        public string Message {  get; }

        public bool Success { get; } = true;

        public int StatusCode { get; }

        public SuccessResponse(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }
    }
}
