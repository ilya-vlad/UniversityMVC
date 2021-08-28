using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Common
{
    public class Student : BaseUniqueEntity
    {
        [Required]        
        public int GroupId { get; set; }

        [Required]        
        public string FirstName { get; set; }

        [Required]        
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required]        
        public float ExamScore { get; set; }
    }
}