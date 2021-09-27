
using MVC.Web.Models.Shared;
using System;

namespace MVC.Web.Models.Course
{
    public class CourseSortViewModel : IGenericSortViewModel
    {        
        public CourseSortState NameSort { get; private set; }
        public CourseSortState DescriptionSort { get; private set; }
        private CourseSortState Current { get; set; }
        
        public CourseSortViewModel(CourseSortState sortOrder)
        {
            NameSort = sortOrder == CourseSortState.NameAsc ? CourseSortState.NameDesc : CourseSortState.NameAsc;
            DescriptionSort = sortOrder == CourseSortState.DescriptionAsc ? CourseSortState.DescriptionDesc : CourseSortState.DescriptionAsc;          
            Current = sortOrder;
        }

        public Enum GetCurrent()
        {
            return Current;
        }
    }
}