using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC.Web.Models.Shared
{
    public class GenericPageViewModel<T> : IGenericPageViewModel where T : class
    {
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
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
            PageSize = pageSize;
        }

        public List<int?> GetPaginationNumbers()
        {
            List<int?> numbers = new List<int?>();
            if(TotalPages < 8)
            {
                return Enumerable.Range(1, TotalPages).Select(x => x).Cast<int?>().ToList();
            }
            else if(PageNumber < 5)
            {
                numbers = Enumerable.Range(1, 6).Cast<int?>().ToList();
                numbers.Add(null);
                numbers.Add(TotalPages);
            }
            else if(PageNumber <= TotalPages - 4)
            {
                numbers.Add(1);
                numbers.Add(null);
                numbers.AddRange(Enumerable.Range(PageNumber - 2, 5).Cast<int?>().ToList());
                numbers.Add(null);
                numbers.Add(TotalPages);
            }
            else
            {
                numbers.Add(1);
                numbers.Add(null);
                numbers.AddRange(Enumerable.Range(TotalPages - 5, 6).Cast<int?>().ToList());
            }
            return numbers;
        }
    }
}