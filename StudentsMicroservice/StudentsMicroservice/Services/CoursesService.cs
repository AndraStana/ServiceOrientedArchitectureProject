using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentsMicroservice.Database;
using StudentsMicroservice.Entities;

namespace StudentsMicroservice.Services
{
    public class CoursesService
    {
        public Course GetCourse(Guid id)
        {
            using var db = new StudentsContext();
            return db.Courses.First(c => c.Id == id);

        }
    }
}
