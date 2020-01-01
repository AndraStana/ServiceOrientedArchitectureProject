using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.EntityFrameworkCore.Internal;
using TeachersMicroservice.Database;
using TeachersMicroservice.Entities;
using TeachersMicroservice.GrpcServicesImplementations;

namespace TeachersMicroservice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");

            InitializeDb();

            const string DefaultHost = "localhost";
            const int Port = 50052;

            var server = new Server
            {
                Services = { TeachersGrpcService.BindService(new TeachersGrpcServiceImpl())
                },
                Ports = { new ServerPort(DefaultHost, Port, ServerCredentials.Insecure) }
            };

            CancellationTokenSource tokenSource = new CancellationTokenSource();
            var serverTask = RunServiceAsync(server, tokenSource.Token);

            Console.WriteLine("Server listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            tokenSource.Cancel();
            Console.WriteLine("Shutting down...");
            serverTask.Wait();


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


        private static async Task RunServiceAsync(Server server, CancellationToken cancellationToken = default(CancellationToken))
        {
            server.Start();

            await AwaitCancellation(cancellationToken);
            await server.ShutdownAsync();
        }

        private static Task AwaitCancellation(CancellationToken token)
        {
            var taskSource = new TaskCompletionSource<bool>();
            token.Register(() => taskSource.SetResult(true));
            return taskSource.Task;
        }

        private static void InitializeDb()
        {
            using var db = new TeachersContext();

            if (!EnumerableExtensions.Any(db.Teachers))
            {
                AddTeachers(db);
            }
            if (!EnumerableExtensions.Any(db.TeacherCourses))
            {
                AddTeacherCourses(db);
            }
        }

        private static void AddTeachers(TeachersContext db)
        {
            db.Teachers.Add(new Teacher()
            {
                Name = "Vlad Emil",
                CareerStartYear = 2005,
                Motto = "Repetition Is the key of success.",
                YearOfBirth = 1980
            });
            db.Teachers.Add(new Teacher()
            {
                Name = "Goerge Racovita",
                CareerStartYear = 2010,
                Motto = "Your limitation it’s only your imagination.",
                YearOfBirth = 1986
            });
            db.Teachers.Add(new Teacher()
            {
                Name = "Radu Cercel ",
                CareerStartYear = 2009,
                Motto = "Push yourself, because no one else is going to do it for you.",
                YearOfBirth = 1982
            });
            db.Teachers.Add(new Teacher()
            {
                Name = "Petre Pavel",
                CareerStartYear = 2010,
                Motto = "Sometimes later becomes never. Do it now.",
                YearOfBirth = 1979
            });
            db.Teachers.Add(new Teacher()
            {
                Name = "Grigore Dana",
                CareerStartYear = 2015,
                Motto = " Great things never come from comfort zones.",
                YearOfBirth = 1990
            });
            db.Teachers.Add(new Teacher()
            {
                Name = "Eliza Radican",
                CareerStartYear = 2007,
                Motto = "Dream it. Wish it. Do it.",
                YearOfBirth = 1985
            });

            db.SaveChanges();
        }

        private static void AddTeacherCourses(TeachersContext db)
        {
            var random = new Random();

            var coursesIds = new List<string> 
                { "038E641D-0F1E-4FB7-AD26-02008443E9F6",
                    "B8F63F2F-4F35-437C-9F7F-3DB46752734D",
                    "ADCA34E7-A43E-4248-B2F6-3FFC0D34A687",
                    "B5F0105C-77DD-4273-8129-5642F2EE1E74",
                    "D37DCBB3-AFC9-473A-BE58-70CC8D921426"
                };

            var teachers = db.Teachers.ToList();
            foreach (var courseId in coursesIds)
            {
                var teacherCourse1 = new TeacherCourse()
                {
                    Id = Guid.NewGuid(), CourseId = Guid.Parse(courseId),
                    TeacherId = teachers.ElementAt(random.Next(0, 2)).Id
                };
                var teacherCourse2 = new TeacherCourse()
                {
                    Id = Guid.NewGuid(),
                    CourseId = Guid.Parse(courseId),
                    TeacherId = teachers.ElementAt(random.Next(2, 4)).Id
                };
                var teacherCourse3 = new TeacherCourse()
                {
                    Id = Guid.NewGuid(),
                    CourseId = Guid.Parse(courseId),
                    TeacherId = teachers.ElementAt(random.Next(4, teachers.Count)).Id
                };
                db.TeacherCourses.Add(teacherCourse1);
                db.TeacherCourses.Add(teacherCourse2);
                db.TeacherCourses.Add(teacherCourse3);

                db.SaveChanges();
            }
        }
    }
}
