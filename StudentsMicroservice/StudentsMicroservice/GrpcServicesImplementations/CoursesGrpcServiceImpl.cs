using Grpc.Core;
using StudentsMicroservice.Services;
using System;
using System.Threading.Tasks;

namespace StudentsMicroservice.GrpcServicesImplementations
{
    public class CoursesGrpcServiceImpl: CoursesGrpcService.CoursesGrpcServiceBase
    {
        public CoursesService CoursesService { get; set; }

        public CoursesGrpcServiceImpl()
        {
            CoursesService = new CoursesService();
        }

        public override Task<GetCourseResponse> GetCourse(GetCourseRequest request
            , ServerCallContext context)
        {
           var course=  CoursesService.GetCourse(Guid.Parse(request.CourseId));

           return Task.FromResult(new GetCourseResponse()
           {
               Id = course.Id.ToString(),
               Name = course.Name
           });
        }
    }
}
