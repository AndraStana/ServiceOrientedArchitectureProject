using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class StudentListModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public string Address { get; set; }
    }

    public class StudentDetailsModel : StudentListModel
    {
        public List<GradeModel> Grades { get; set; }
    }
}
