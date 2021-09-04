using Microsoft.EntityFrameworkCore;
using MVC.Common;


namespace MVC.DataAccess
{
    public class UniversityContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Course> Courses { get; set; }        

        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options)
        {
            
        }
    }
}
