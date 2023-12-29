using Application.Wrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrapper.Concrete
{
    public class ErrorResponse : IErrorResponse
    {
        public List<string> Errors { get; private set; } = new List<string>();

        public bool Success { get; } = false;

        public int StatusCode { get; }

        public ErrorResponse(int statuscode, List<string> errors)
        {
            StatusCode = statuscode;
            Errors = errors;
        }

        public ErrorResponse(int statuscode, string error)
        {
            StatusCode = statuscode;
            Errors.Add(error);
        }
    }
}
