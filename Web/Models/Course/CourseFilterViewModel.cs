

namespace MVC.Web.Models.Course
{
    public class CourseFilterViewModel
    {
        public string SelectedName { get; set; }

        public CourseFilterViewModel(string name)
        {
            SelectedName = name;
        }        
    }
}
