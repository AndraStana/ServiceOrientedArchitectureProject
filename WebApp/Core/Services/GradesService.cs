using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessMicroservice;
using Core.Models;
using Grpc.Core;

namespace Core.Services
{
    public class GradesService
    {
        const string channelTarget = "localhost:50051";

        public async void AddGradeAsync(AddGradeModel model)
        {
            var channel = new Channel(channelTarget, ChannelCredentials.Insecure);
            try
            {
                var client = new GradesGrpcService.GradesGrpcServiceClient(channel);
                var request = new AddGradeRequest()
                {
                    CourseId = model.CourseId.ToString(),
                    StudentId = model.StudentId.ToString(),
                    Mark = model.Mark
                };

                //var response = await client.AddGradeAsync(request);
                var response =  client.AddGradeAsync(request);



            }
            finally
            {
                await channel.ShutdownAsync();
            }
        }
    }
}
