using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Collections.Generic;

interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T Get(int id);
    void Create(T item);
    void Update(T item);
    void Delete(int id);
}

public class CourseRepository : IRepository<Course>
{
    private UniversityContext db;

    public CourseRepository(UniversityContext context)
    {
        this.db = context;
    }

    public IEnumerable<Course> GetAll()
    {
        return db.Courses;
    }

    public Course Get(int id)
    {Update
        return db.Courses.Find(id);
    }

    public void Create(Course course)
    {
        db.Courses.Add(course);
    }

    public void Update(Course course)
    {
        db.Entry(course).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        Course course = db.Courses.Find(id);
        if (course != null)
            db.Courses.Remove(course);
    }
}

public class GroupRepository : IRepository<Group>
{
    private UniversityContext db;

    public GroupRepository(UniversityContext context)
    {
        this.db = context;
    }

    public IEnumerable<Group> GetAll()
    {
        return db.Groups;
    }

    public Group Get(int id)
    {
        return db.Groups.Find(id);
    }

    public void Create(Group group)
    {
        db.Groups.Add(group);
    }

    public void Update(Group group)
    {
        db.Entry(group).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        Group group = db.Groups.Find(id);
        if (group != null)
            db.Groups.Remove(group);
    }
}

public class StudentRepository : IRepository<Student>
{
    private UniversityContext db;

    public StudentRepository(UniversityContext context)
    {
        this.db = context;
    }

    public IEnumerable<Student> GetAll()
    {
        return db.Students;
    }

    public Student Get(int id)
    {
        return db.Students.Find(id);
    }

    public void Create(Student student)
    {
        db.Students.Add(student);
    }

    public void Update(Student student)
    {
        db.Entry(student).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        Student student = db.Students.Find(id);
        if (student != null)
            db.Students.Remove(student);
    }
}
