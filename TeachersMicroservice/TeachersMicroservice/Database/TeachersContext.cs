using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TeachersMicroservice.Entities;

namespace TeachersMicroservice.Database
{
    class TeachersContext : DbContext
    {
        public TeachersContext()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-A0UAI1B; Initial Catalog = TeachersDb; Integrated Security = True;");
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
    }
}
