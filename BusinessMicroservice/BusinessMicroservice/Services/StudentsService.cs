using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessMicroservice.Database;
using BusinessMicroservice.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BusinessMicroservice.Services
{
    public class StudentsService
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            using var db = new StudentsContext();
            students = db.Students.ToList();
            return students;
        }

        public Student GetStudentDetails(Guid id)
        {
            using var db = new StudentsContext();
            var student = db.Students
                .Include(s => s.Grades)
                .ThenInclude(g => g.Course)
                .FirstOrDefault(s => s.Id == id);
            return student;
        }

        public void DeleteStudent(Guid id)
        {
            using var db = new StudentsContext();

            var grades = db.Grades.Where(g => g.StudentId == id).ToList();
            db.Grades.RemoveRange(grades);

            var student = db.Students.First(s => s.Id == id);

            db.Students.Remove(student);
            db.SaveChanges();
        }

    }

}

