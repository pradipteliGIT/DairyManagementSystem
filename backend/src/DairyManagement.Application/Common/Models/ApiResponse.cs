using System;
using System.Collections.Generic;
using System.Text;

namespace DairyManagement.Application.Common.Models
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; private set; }

        public string Message { get; private set; } = string.Empty;

        public T? Data { get; private set; }

        public Dictionary<string, string[]>? Errors { get; private set; }

        private ApiResponse()
        {
        }

        public static ApiResponse<T> SuccessResponse(
            T data,
            string message = "Request completed successfully.")
        {
            return new ApiResponse<T>
            {
                IsSuccess = true,
                Message = message,
                Data = data
            };
        }

        public static ApiResponse<T> FailureResponse(
            string message,
            Dictionary<string, string[]>? errors = null)
        {
            return new ApiResponse<T>
            {
                IsSuccess = false,
                Message = message,
                Errors = errors
            };
        }
    }
}
