using System;
using System.Collections.Generic;
using System.Text;

namespace DairyManagement.Application.Common.Constants
{
    public static class ErrorMessages
    {
        // General
        public const string InternalServerError =
            "An unexpected error occurred. Please try again later.";

        public const string InvalidRequest =
            "The request contains invalid data.";

        public const string RecordNotFound =
            "The requested record was not found.";

        // Authentication
        public const string InvalidCredentials =
            "Invalid username or password.";

        public const string Unauthorized =
            "You are not authorized to perform this action.";

        public const string AccountInactive =
            "Your account is inactive.";

        // Customer
        public const string CustomerNotFound =
            "Customer not found.";

        public const string CustomerAlreadyExists =
            "A customer with the same details already exists.";

        // Company
        public const string CompanyNotFound =
            "Company details not found.";

        // Inventory
        public const string ProductNotFound =
            "Product not found.";

        public const string InsufficientStock =
            "Insufficient stock available.";
    }
}
