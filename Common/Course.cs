using System.ComponentModel.DataAnnotations;

namespace MVC.Common
{
    public class Course
    {
        public int Id { get; set; }

        [Required]        
        public string Name { get; set; }       
        
        public string Description { get; set; }
    }
}
