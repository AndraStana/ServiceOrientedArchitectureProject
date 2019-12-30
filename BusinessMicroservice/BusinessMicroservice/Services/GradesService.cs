using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessMicroservice.Database;
using BusinessMicroservice.Entities;

namespace BusinessMicroservice.Services
{
    public class GradesService
    {

        public void AddGrade(Grade grade)
        {
            using var db = new StudentsContext();

            db.Grades.Add(grade);
            db.SaveChanges();
        }
    }
}
