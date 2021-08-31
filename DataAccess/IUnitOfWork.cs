using System;

namespace MVC.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        public CoursesRepository Courses { get; }
        public GroupsRepository Groups { get; }
        public StudentsRepository Students { get; }

        public void Save();   
    }
}
