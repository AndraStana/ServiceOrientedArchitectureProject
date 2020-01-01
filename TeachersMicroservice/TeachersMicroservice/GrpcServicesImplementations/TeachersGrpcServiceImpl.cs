using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using TeachersMicroservice.Services;

namespace TeachersMicroservice.GrpcServicesImplementations
{
    public class TeachersGrpcServiceImpl : TeachersGrpcService.TeachersGrpcServiceBase
    { 
        public TeachersService TeachersService { get; set; }

        public TeachersGrpcServiceImpl()
        {
                TeachersService = new TeachersService();
        }

        public override Task<GetTeachersResponse> GetTeachers(GetTeachersRequest request, ServerCallContext context)
        {
            var teachers =TeachersService.GetTeachersOfCourse(Guid.Parse(request.CourseId)).Select(
                t => new TeacherMessage()
                {
                    Id = t.Id.ToString(),
                    Name= t.Name,
                    CareerStartYear = t.CareerStartYear,
                    YearOfBirth = t.CareerStartYear,
                    Motto = t.Motto
                }
            ).ToList();


            var response = new GetTeachersResponse();

            response.Teachers.AddRange(teachers);

            return Task.FromResult(response);
        }
    }
}
