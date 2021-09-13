using MVC.Web.Models.Shared;

namespace MVC.Web.Models.Course
{
    public class CoursePageViewModel : GenericPageViewModel<CoursePageViewModel>
    {
        public CoursePageViewModel(int count, int pageNumber, int pageSize)
             : base(count, pageNumber, pageSize)
        {

        }
    }
}