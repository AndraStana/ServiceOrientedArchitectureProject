using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class CourseDetailsModel
    {
        public CourseModel Course { get; set; }
        public List<TeacherModel> Teachers { get; set; }
    }

    public class CourseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
