using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Interfaces;
using MVC.Models;

namespace MVC.Implementations
{
    public class CoursesRepository : Repository<Course>, ICoursesRepository
    {
        public CoursesRepository(UniversityContext context)
            : base(context)
        {

        }       
    }
}
