using MVC.Web.Models.Shared;

namespace MVC.Web.Models.Student
{
    public class StudentPageViewModel : GenericPageViewModel<StudentPageViewModel>
    {
       public StudentPageViewModel(int count, int pageNumber, int pageSize) 
            : base (count, pageNumber, pageSize)
        {
            
        }       
    }
}