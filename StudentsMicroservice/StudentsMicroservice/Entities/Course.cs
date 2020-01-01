using System;
using System.Collections.Generic;

namespace StudentsMicroservice.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Grade> Grades { get; set; }

    }
}
