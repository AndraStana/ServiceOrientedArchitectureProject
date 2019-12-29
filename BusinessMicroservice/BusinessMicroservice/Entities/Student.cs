using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessMicroservice.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth  { get; set; }
        public string Address { get; set; }
        public List<Grade> Grades { get; set; }

    }
}
