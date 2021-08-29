
namespace MVC.Web.Models.Group
{
    public class GroupSortViewModel
    {        
        public GroupSortState NameSort { get; private set; }        
        public GroupSortState Current { get; private set; }
        
        public GroupSortViewModel(GroupSortState sortOrder)
        {
            NameSort = sortOrder == GroupSortState.NameAsc ? GroupSortState.NameDesc : GroupSortState.NameAsc;          
            Current = sortOrder;
        }
    }
}
