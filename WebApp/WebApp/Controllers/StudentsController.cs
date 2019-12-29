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

        [HttpGet]
        public async Task<ActionResult<List<StudentListModel>>> GetStudents()
        {
            var service = new StudentsService();

            var students = await service.GetStudentsAsync();
            return students;
        }

    }
}