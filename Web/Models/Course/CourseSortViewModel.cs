
namespace MVC.Web.Models.Course
{
    public class CourseSortViewModel
    {        
        public CourseSortState NameSort { get; private set; }
        public CourseSortState DescriptionSort { get; private set; }
        public CourseSortState Current { get; private set; }
        
        public CourseSortViewModel(CourseSortState sortOrder)
        {
            NameSort = sortOrder == CourseSortState.NameAsc ? CourseSortState.NameDesc : CourseSortState.NameAsc;
            DescriptionSort = sortOrder == CourseSortState.DescriptionAsc ? CourseSortState.DescriptionDesc : CourseSortState.DescriptionAsc;          
            Current = sortOrder;
        }
    }
}
