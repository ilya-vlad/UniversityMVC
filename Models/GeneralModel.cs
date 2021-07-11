using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class GeneralModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Student> Students { get; set; }        
    }
}
