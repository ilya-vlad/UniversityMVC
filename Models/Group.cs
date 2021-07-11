using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
    }
}
