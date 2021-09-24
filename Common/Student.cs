using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Common
{
    public class Student : BaseUniqueEntity
    {
        public int GroupId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:0.0}")]
        public float ExamScore { get; set; }
    }
}