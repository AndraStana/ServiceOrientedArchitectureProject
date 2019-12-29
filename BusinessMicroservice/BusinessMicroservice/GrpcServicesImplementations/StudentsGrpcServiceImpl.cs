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
    }
}
