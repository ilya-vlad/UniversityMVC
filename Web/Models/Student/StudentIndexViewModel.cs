using System.Linq;

namespace MVC.Web.Models.Student
{
    public class StudentIndexViewModel
    {
        public IQueryable<MVC.Common.Student> Students { get; set; }
        public StudentPageViewModel PageViewModel { get; set; }
        public StudentFilterViewModel FilterViewModel { get; set; }
        public StudentSortViewModel SortViewModel { get; set; }
    }
}
