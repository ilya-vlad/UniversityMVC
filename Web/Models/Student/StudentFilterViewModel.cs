using MVC.Web.Models.Shared;

namespace MVC.Web.Models.Student
{
    public class StudentFilterViewModel : GenericFilterViewModel<StudentFilterViewModel>
    {
        public StudentFilterViewModel(string lastName) : base(lastName)
        {
            
        }        
    }
}