using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class GradeModel
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public List<int> Marks { get; set; }
    }
}
