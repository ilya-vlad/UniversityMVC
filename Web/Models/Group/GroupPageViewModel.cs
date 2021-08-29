﻿using System;

namespace MVC.Web.Models.Group
{
    public class GroupPageViewModel
    {
        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; }

        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }

        public GroupPageViewModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }       
    }
}
