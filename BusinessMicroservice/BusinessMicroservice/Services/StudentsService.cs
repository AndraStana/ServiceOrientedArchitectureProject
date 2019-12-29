using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessMicroservice.Database;
using BusinessMicroservice.Entities;

namespace BusinessMicroservice.Services
{
    public class StudentsService
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>(); 

            using (var db = new StudentsContext())
            {
                students = db.Students.ToList();
            }
            return students;
        }

    }
}
