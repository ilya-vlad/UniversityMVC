using MVC.Common.Data;

namespace MVC.Domain.DataAccess
{
    public class CoursesRepository : Repository<Course>, ICoursesRepository
    {
        public CoursesRepository(UniversityContext context)
            : base(context)
        {

        }       
    }
}
