using System.ComponentModel.DataAnnotations;

namespace MVC.Common
{
    public class Group : BaseUniqueEntity
    {
        [Required]        
        public int CourseId { get; set; }

        [Required]        
        public string Name { get; set; }
    }
}
