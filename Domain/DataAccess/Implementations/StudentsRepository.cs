using MVC.Common.Data;

namespace MVC.Domain.DataAccess
{
    public class StudentsRepository : Repository<Student>, IStudentsRepository
    {
        public StudentsRepository(UniversityContext context)
            : base(context)
        {

        }
    }
}
