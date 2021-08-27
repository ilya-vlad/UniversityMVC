using System.ComponentModel.DataAnnotations;

namespace MVC.Common
{
    public class Course : BaseUniqueEntity
    {
        [Required]        
        public string Name { get; set; }
        
        public string Description { get; set; }
    }
}
