using MVC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Web.Models
{
    public class StudentFilterViewModel
    {
        public string SelectedLastName { get; set; }

        public StudentFilterViewModel(string lastName)
        {
            SelectedLastName = lastName;
        }        
    }
}
