using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        public StudentsService service;
        public StudentsController()
        {
             service = new StudentsService();
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentListModel>>> GetStudents()
        {
            var students = await service.GetStudentsAsync();
            return students;
        }


        [HttpGet]
        public async Task<ActionResult<StudentDetailsModel>> GetStudentDetails(Guid id)
        {
            var student = await service.GetStudentDetailsAsync(id);
            return student;
        }

        [HttpDelete("{id}")]
        public void DeleteStudent(Guid id)
        {
            service.DeleteStudentAsync(id);
        }

    }
}