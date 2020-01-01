using System;
using System.Threading.Tasks;
using BusinessMicroservice;
using Grpc.Core;
using StudentsMicroservice.Entities;
using StudentsMicroservice.Services;

namespace StudentsMicroservice.GrpcServicesImplementations
{
    public class GradesGrpcServiceImpl: GradesGrpcService.GradesGrpcServiceBase
    {
        public GradesService GradesService { get; set; }

        public GradesGrpcServiceImpl()
        {
            GradesService = new GradesService();
        }

        public override Task<AddGradeResponse> AddGrade(AddGradeRequest request, ServerCallContext context)
        {
            GradesService.AddGrade(new Grade()
            {
                CourseId = Guid.Parse(request.CourseId),
                StudentId = Guid.Parse(request.StudentId),
                Mark = request.Mark
            });

            return  Task.FromResult(new AddGradeResponse());
        }

    }
}
