using System.ComponentModel.DataAnnotations;

namespace MVC.Common
{
    public class Group
    {
        public int Id { get; set; }

        [Required]        
        public int CourseId { get; set; }

        [Required]        
        public string Name { get; set; }
    }
}
