using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Interfaces;
using MVC.Models;

namespace MVC.Implementations
{
    public class StudentsRepository : Repository<Student>, IStudentsRepository
    {
        public StudentsRepository(UniversityContext context)
            : base(context)
        {

        }
    }
}
