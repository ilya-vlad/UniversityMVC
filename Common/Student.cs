using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Common
{
    public class Student
    {
        public int Id { get; set; }

        [Required]        
        public int GroupId { get; set; }

        [Required]        
        public string FirstName { get; set; }

        [Required]        
        public string LastName { get; set; }

        [Required]        
        public DateTime DateOfBirth { get; set; }

        [Required]        
        public float ExamScore { get; set; }
    }
}