using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersMicroservice.Entities
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }

        public int YearOfBirth { get; set; }
        public int CareerStartYear { get; set; }
    }
}
