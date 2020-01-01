using StudentsMicroservice.Database;
using StudentsMicroservice.Entities;

namespace StudentsMicroservice.Services
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
