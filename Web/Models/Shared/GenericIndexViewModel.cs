using System.Linq;


namespace MVC.Web.Models.Shared
{
    public class GenericIndexViewModel<Common, PageView, FilterView, SortView> 
        where Common : class
        where PageView : class
        where FilterView : class
        where SortView : class
    {
        public IQueryable<Common> Items { get; set; }
        public PageView PageViewModel { get; set; }
        public FilterView FilterViewModel { get; set; }
        public SortView SortViewModel { get; set; }
    }
}
