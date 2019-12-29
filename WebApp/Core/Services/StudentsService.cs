using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessMicroservice;
using Core.Models;
using Grpc.Core;

namespace Core.Services
{
    public class StudentsService
    {
        const string channelTarget = "localhost:50051";
        public async Task<List<StudentListModel>> GetStudentsAsync()
        {
            var channel = new Channel(channelTarget, ChannelCredentials.Insecure);
            try
            {
                var client = new StudentsGrpService.StudentsGrpServiceClient(channel);
                var request = new GetStudentsRequest();

                var response = await client.GetStudentsAsync(request);

                var students = response.Students.Select(s => new StudentListModel()
                {
                    Id = new Guid(s.Id),
                    Address = s.Address,
                    Name = s.Name,
                    YearOfBirth = s.YearOfBirth
                }).ToList();


                return students;
            }
            finally
            {
                await channel.ShutdownAsync();
            }
        }
    }
}
