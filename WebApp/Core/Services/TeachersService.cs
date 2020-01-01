using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Grpc.Core;
using TeachersMicroservice;

namespace Core.Services
{
    public class TeachersService
    {
        const string channelTarget = "localhost:50052";

        public async Task<List<TeacherModel>> GetTeachersAsync(Guid id)
        {
            var channel = new Channel(channelTarget, ChannelCredentials.Insecure);
            try
            {
                var client = new TeachersGrpcService.TeachersGrpcServiceClient(channel);
                var request = new GetTeachersRequest {CourseId = id.ToString()};
                var response = await client.GetTeachersAsync(request);

                var teachers = response.Teachers.Select(t => new TeacherModel()
                {
                    Id = Guid.Parse(t.Id),
                    Name = t.Name,
                    CareerStartYear = t.CareerStartYear,
                    Motto = t.Motto,
                    YearOfBirth = t.YearOfBirth
                }).ToList();

                return teachers;

            }

            finally
            {
                await channel.ShutdownAsync();
            }
        }

    }
}
