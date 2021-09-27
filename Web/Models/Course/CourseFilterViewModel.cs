using MVC.Web.Models.Shared;

namespace MVC.Web.Models.Course
{
    public class CourseFilterViewModel : GenericFilterViewModel<CourseFilterViewModel>
    {
        public CourseFilterViewModel(string name) : base(name)
        {

        }
    }    
}