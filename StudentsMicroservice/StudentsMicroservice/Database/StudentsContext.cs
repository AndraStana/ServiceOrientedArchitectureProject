using Microsoft.EntityFrameworkCore;
using StudentsMicroservice.Entities;

namespace StudentsMicroservice.Database
{
    public class StudentsContext : DbContext
    {

        public StudentsContext()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Data Source = DESKTOP-A0UAI1B; Initial Catalog = StudentsDb; Integrated Security = True;");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
