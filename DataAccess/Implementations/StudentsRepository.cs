using MVC.Common;

namespace MVC.DataAccess
{
    public class StudentsRepository : Repository<Student>, IStudentsRepository
    {
        public StudentsRepository(UniversityContext context)
            : base(context)
        {

        }
    }
}
