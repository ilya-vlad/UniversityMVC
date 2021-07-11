using MVC.Models;
using System;

public class UnitOfWork : IDisposable
{
    private UniversityContext db;
    private CourseRepository courseRepository;
    private GroupRepository groupRepository;
    private StudentRepository studentRepository;

    public UnitOfWork(UniversityContext context)
    {
        this.db = context;
    }
    public CourseRepository Courses
    {
        get
        {
            if (courseRepository == null)
                courseRepository = new CourseRepository(db);
            return courseRepository;
        }
    }

    public GroupRepository Groups
    {
        get
        {
            if (groupRepository == null)
                groupRepository = new GroupRepository(db);
            return groupRepository;
        }
    }

    public StudentRepository Students
    {
        get
        {
            if (studentRepository == null)
                studentRepository = new StudentRepository(db);
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