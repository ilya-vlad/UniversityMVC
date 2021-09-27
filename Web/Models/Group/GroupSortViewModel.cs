
using MVC.Web.Models.Shared;
using System;

namespace MVC.Web.Models.Group
{
    public class GroupSortViewModel : IGenericSortViewModel
    {        
        public GroupSortState NameSort { get; private set; }        
        private GroupSortState Current { get; set; }
        
        public GroupSortViewModel(GroupSortState sortOrder)
        {
            NameSort = sortOrder == GroupSortState.NameAsc ? GroupSortState.NameDesc : GroupSortState.NameAsc;          
            Current = sortOrder;
        }

        public Enum GetCurrent()
        {
            return Current;
        }
    }
}