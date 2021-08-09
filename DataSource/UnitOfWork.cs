using MVC.Models;
using MVC;
using MVC.Implementations;
using System;

namespace MVC
{
    public class UnitOfWork : IDisposable
    {
        private UniversityContext db;
        private CoursesRepository courseRepository;
        private GroupsRepository groupRepository;
        private StudentsRepository studentRepository;      
        

        public UnitOfWork(UniversityContext context)
        {
            this.db = context;
        }
        public CoursesRepository Courses
        {
            get
            {
                if (courseRepository == null)
                    courseRepository = new CoursesRepository(db);
                return courseRepository;
            }
        }

        public GroupsRepository Groups
        {
            get
            {
                if (groupRepository == null)
                    groupRepository = new GroupsRepository(db);
                return groupRepository;
            }
        }

        public StudentsRepository Students
        {
            get
            {
                if (studentRepository == null)
                    studentRepository = new StudentsRepository(db);
                return studentRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}