using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TheBattleShipClient.Exceptions
{
    public class ApiException : Exception
    {
        public ErrorResponse ApiResponse { get; set; }

        public ApiException(ErrorResponse apiResponse)
        {
            ApiResponse = apiResponse;
        }

        public ApiException(string message, ErrorResponse apiResponse) : base(message)
        {
            ApiResponse = apiResponse;
        }

        public ApiException(string message, Exception innerException, ErrorResponse apiResponse) : base(message, innerException)
        {
            ApiResponse = apiResponse;
        }
    }
}
