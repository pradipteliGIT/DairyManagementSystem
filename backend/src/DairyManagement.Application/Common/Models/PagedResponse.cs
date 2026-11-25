using System;
using System.Collections.Generic;
using System.Text;

namespace DairyManagement.Application.Common.Models
{
    public class PagedResponse<T>
    {
        public IReadOnlyList<T> Items { get; private set; } =
            Array.Empty<T>();

        public int PageNumber { get; private set; }

        public int PageSize { get; private set; }

        public int TotalCount { get; private set; }

        public int TotalPages { get; private set; }

        public bool HasPreviousPage => PageNumber > 1;

        public bool HasNextPage => PageNumber < TotalPages;

        private PagedResponse()
        {
        }

        public static PagedResponse<T> Create(
            IReadOnlyList<T> items,
            int pageNumber,
            int pageSize,
            int totalCount)
        {
            return new PagedResponse<T>
            {
                Items = items,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = pageSize > 0
                    ? (int)Math.Ceiling((double)totalCount / pageSize)
                    : 0
            };
        }
    }
}
