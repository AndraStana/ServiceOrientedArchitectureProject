using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeachersMicroservice.Database;
using TeachersMicroservice.Entities;

namespace TeachersMicroservice.Services
{
    public class TeachersService
    {
        public List<Teacher> GetTeachersOfCourse(Guid courseId)
        {
            using var db = new TeachersContext();

            var teachersIds = db.TeacherCourses.Where(tc => tc.CourseId == courseId)
                .Select(tc => tc.TeacherId).ToList();

            var teachers = db.Teachers.Where(t => teachersIds.Contains(t.Id)).ToList();

            return teachers;
        }

    }
}
