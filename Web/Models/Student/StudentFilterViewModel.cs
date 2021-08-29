
namespace MVC.Web.Models.Student
{
    public class StudentFilterViewModel
    {
        public string SelectedLastName { get; set; }

        public StudentFilterViewModel(string lastName)
        {
            SelectedLastName = lastName;
        }        
    }
}
