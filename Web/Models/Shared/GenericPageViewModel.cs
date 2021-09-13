using System;

namespace MVC.Web.Models.Shared
{
    public class GenericPageViewModel<T> where T : class
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

        public GenericPageViewModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }
    }
}