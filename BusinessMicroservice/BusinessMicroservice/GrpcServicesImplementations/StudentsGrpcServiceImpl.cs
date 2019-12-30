using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessMicroservice.Entities;
using BusinessMicroservice.Services;
using Grpc.Core;

namespace BusinessMicroservice.GrpcServicesImplementations
{
    public class StudentsGrpcServiceImpl : StudentsGrpService.StudentsGrpServiceBase
    {
        public StudentsService StudentsService { get; set; }
        public StudentsGrpcServiceImpl()
        {
            StudentsService = new StudentsService();
        }

        public override Task<GetStudentsResponse> GetStudents(GetStudentsRequest request, ServerCallContext context)
        {

            var students = StudentsService.GetStudents().Select(s => new StudentMessage()
            {
                Name = s.Name,
                Address = s.Address,
                Id = s.Id.ToString(),
                YearOfBirth = s.YearOfBirth
            }).ToList();


            var response = new GetStudentsResponse();

            response.Students.AddRange(students);

            return Task.FromResult(response);
        }

        public override Task<GetStudentDetailsResponse> GetStudentDetails(GetStudentDetailsRequest request, ServerCallContext context)
        {
            var student = StudentsService.GetStudentDetails(Guid.Parse(request.Id));


            var allCourses = student.Grades.Select(g => g.Course).Distinct();

            var grades = new List<GradeMessage>();

            foreach (var course in allCourses)
            {
                var grade = new GradeMessage()
                {
                    CourseName = course.Name,
                };
                grade.Marks.AddRange(student.Grades.Where(g => g.CourseId == course.Id).Select(g=>g.Mark).ToList());
                grades.Add(grade);
            }


            var response = new GetStudentDetailsResponse()
            {
                Id = student.Id.ToString(),
                YearOfBirth = student.YearOfBirth,
                Address = student.Address,
                Name = student.Name
            };
            response.Grades.AddRange(grades);

            return Task.FromResult(response);
        }
    }
}
