using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using StudentsMicroservice;
using TeachersMicroservice;

namespace WebApp.Controllers
{
    [Route("api/[controller]/[action]")]

    public class CoursesController : Controller
    {
        public TeachersService teachersService;
        public CoursesService coursesService;


        public CoursesController()
        {
            teachersService = new TeachersService();
            coursesService = new CoursesService();

        }

        [HttpGet]
        public async Task<ActionResult<CourseDetailsModel>> GetCourseDetails(Guid id)
        {
            var course = await coursesService.GetCourseAsync(id);
            var teachers = await teachersService.GetTeachersAsync(id);

            var courseDetails = new CourseDetailsModel();

            courseDetails.Course = course;
            courseDetails.Teachers = teachers;

            return courseDetails;
        }

    }
}
