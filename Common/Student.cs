using System;

namespace MVC.Common
{
    public class Student
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float ExamScore { get; set; }
    }
}