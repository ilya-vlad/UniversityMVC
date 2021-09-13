

namespace MVC.Web.Models.Shared
{
    public class GenericFilterViewModel<T> where T : class
    {
        public string SearchedName { get; set; }

        public GenericFilterViewModel(string searchedName)
        {
            SearchedName = searchedName;
        }
    }
}
