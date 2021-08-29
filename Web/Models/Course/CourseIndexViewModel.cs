using System.Linq;

namespace MVC.Web.Models.Course
{
    public class CourseIndexViewModel
    {
        public IQueryable<MVC.Common.Course> Courses { get; set; }
        public CoursePageViewModel PageViewModel { get; set; }
        public CourseFilterViewModel FilterViewModel { get; set; }
        public CourseSortViewModel SortViewModel { get; set; }
    }
}
