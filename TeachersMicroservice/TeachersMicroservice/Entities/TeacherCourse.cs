using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersMicroservice.Entities
{
    public class TeacherCourse
    {
        public Guid Id { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid CourseId { get; set; }
    }
}
