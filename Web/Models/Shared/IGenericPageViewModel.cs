﻿
using System.Collections.Generic;

namespace MVC.Web.Models.Shared
{
    public interface IGenericPageViewModel
    {
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public bool HasPreviousPage { get; }
        public bool HasNextPage { get; }
        public List<int?> GetPaginationNumbers();
    }
}
