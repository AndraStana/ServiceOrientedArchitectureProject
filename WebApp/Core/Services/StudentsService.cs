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
                var client = new StudentsGrpcService.StudentsGrpcServiceClient(channel);
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


        public async Task<StudentDetailsModel> GetStudentDetailsAsync(Guid id)
        {
            var channel = new Channel(channelTarget, ChannelCredentials.Insecure);
            try
            {
                var client = new StudentsGrpcService.StudentsGrpcServiceClient(channel);
                var request = new GetStudentDetailsRequest()
                {
                    Id = id.ToString()
                };

                var student = await client.GetStudentDetailsAsync(request);

                var studentModel = new StudentDetailsModel()
                {
                    Id = Guid.Parse(student.Id),
                    Name = student.Name,
                    Address = student.Address,
                    YearOfBirth = student.YearOfBirth,
                    Grades = student.Grades.Select(g => new GradeModel()
                    {
                        CourseName = g.CourseName,
                        CourseId = Guid.Parse(g.CourseId),
                        Marks = g.Marks.ToList()
                    }).ToList()
                };


                return studentModel;
            }
            finally
            {
                await channel.ShutdownAsync();
            }
        }
    }
}
