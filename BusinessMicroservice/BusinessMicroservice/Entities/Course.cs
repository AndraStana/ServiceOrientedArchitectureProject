using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessMicroservice.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Grade> Grades { get; set; }

    }
}
