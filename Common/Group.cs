using System.ComponentModel.DataAnnotations;

namespace MVC.Common
{
    public class Group : BaseUniqueEntity
    {
        public int CourseId { get; set; }

        public string Name { get; set; }
    }
}
