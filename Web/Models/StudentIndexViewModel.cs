using MVC.Common;
using System.Linq;

namespace MVC.Web.Models
{
    public class StudentIndexViewModel
    {
        public IQueryable<Student> Students { get; set; }
        public StudentPageViewModel PageViewModel { get; set; }
        public StudentFilterViewModel FilterViewModel { get; set; }
        public StudentSortViewModel SortViewModel { get; set; }
    }
}
