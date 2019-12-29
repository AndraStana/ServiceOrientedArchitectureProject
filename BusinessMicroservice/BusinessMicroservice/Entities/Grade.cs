using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessMicroservice.Entities
{
    public class Grade
    {
        public Guid Id { get; set; }
        public int Mark { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}
