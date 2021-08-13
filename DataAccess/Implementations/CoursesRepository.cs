using MVC.Common;

namespace MVC.DataAccess
{
    public class CoursesRepository : Repository<Course>, ICoursesRepository
    {
        public CoursesRepository(UniversityContext context)
            : base(context)
        {

        }       
    }
}
