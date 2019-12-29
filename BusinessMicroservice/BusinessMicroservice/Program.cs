using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BusinessMicroservice.Database;
using BusinessMicroservice.Entities;
using BusinessMicroservice.GrpcServicesImplementations;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BusinessMicroservice
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Start...");

                const string DefaultHost = "localhost";
                const int Port = 50051;

                var server = new Server
                {
                    Services = { StudentsGrpService.BindService(new StudentsGrpcServiceImpl()) },
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
                

                //InitializeDb();

            Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
        }


        private static async Task RunServiceAsync(Server server, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Start server
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
            using (var db = new StudentsContext())
            {

                if (!EnumerableExtensions.Any(db.Students))
                {
                    AddStudents(db);
                }

                if (!EnumerableExtensions.Any(db.Courses))
                {
                    AddCourses(db);
                }

                if (!EnumerableExtensions.Any(db.Grades))
                {
                    AddGrades(db);
                }

            }
        }

        private static void AddGrades(StudentsContext db)
        {
            db.Grades.Add(new Grade()
                {Id = Guid.NewGuid(), Mark = 10, StudentId = db.Students.First().Id, CourseId = db.Courses.First().Id});

            db.Grades.Add(new Grade()
                { Id = Guid.NewGuid(), Mark = 7, StudentId = db.Students.First().Id, CourseId = db.Courses.First().Id });
            db.SaveChanges();

        }

        private static void AddCourses(StudentsContext db)
        {
            db.Courses.Add(new Course() {Id = Guid.NewGuid(), Name = "Math"});
            db.Courses.Add(new Course() { Id = Guid.NewGuid(), Name = "English" });
            db.Courses.Add(new Course() { Id = Guid.NewGuid(), Name = "History" });
            db.Courses.Add(new Course() { Id = Guid.NewGuid(), Name = "Geography" });
            db.Courses.Add(new Course() { Id = Guid.NewGuid(), Name = "Biology" });
            db.SaveChanges();

        }

        private static void AddStudents(StudentsContext db)
        {
            db.Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Alexandru Popescu", YearOfBirth=1997, Address="Strada Ploplor, Cluj-Napoca" });
            db.Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Mihai Pop", YearOfBirth = 1997, Address = "Strada Ploplor, Cluj-Napoca" });
            db.Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Raluca Iovan", YearOfBirth = 1996, Address = "Strada Ploplor, Cluj-Napoca" });
            db.Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Cristina Popivici", YearOfBirth = 1995, Address = "Strada Ploplor, Cluj-Napoca" });
            db.Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Andreea Daniel", YearOfBirth = 1994, Address = "Strada Ploplor, Cluj-Napoca" });
            db.SaveChanges();

        }
    }
}
