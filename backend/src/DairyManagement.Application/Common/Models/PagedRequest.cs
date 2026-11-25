using DairyManagement.Application.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace DairyManagement.Application.Common.Models
{
    public class PagedRequest
    {
        public int PageNumber { get; set; } = PaginationConstants.DefaultPageNumber;

        public int PageSize { get; set; } = PaginationConstants.DefaultPageSize;

        public string? SearchTerm { get; set; }
    }
}
