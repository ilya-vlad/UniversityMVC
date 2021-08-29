using System.Linq;

namespace MVC.Web.Models.Group
{
    public class GroupIndexViewModel
    {
        public IQueryable<MVC.Common.Group> Groups { get; set; }
        public GroupPageViewModel PageViewModel { get; set; }
        public GroupFilterViewModel FilterViewModel { get; set; }
        public GroupSortViewModel SortViewModel { get; set; }
    }
}
