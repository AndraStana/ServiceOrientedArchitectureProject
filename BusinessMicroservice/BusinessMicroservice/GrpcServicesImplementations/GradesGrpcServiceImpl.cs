using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessMicroservice.Entities;
using BusinessMicroservice.Services;
using Grpc.Core;

namespace BusinessMicroservice.GrpcServicesImplementations
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
