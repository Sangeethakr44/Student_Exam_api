using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_Exam.Data;
using Student_Exam.Models;

namespace Student_Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : Controller
    {
        private readonly ApplicationDBContext applicationDBContext;

        public MasterController(ApplicationDBContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }
        [HttpGet("GetAllStudents")]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            return await applicationDBContext.students.ToListAsync();
        }
        [HttpPost("create-user")]
        public IActionResult CreateUser(StudentDto addCustomerDto)
        {
            var user = new Student()
            {
                Name = addCustomerDto.Name,
                Email = addCustomerDto.Email,
               
            };
            applicationDBContext.students.Add(user);
            applicationDBContext.SaveChanges();
            return Ok(user);
        }
        [HttpGet("GetAllCourses")]
        public async Task<ActionResult<IEnumerable<Course>>> GetAllCourses()
        {
            return await applicationDBContext.courses.ToListAsync();
        }
        [HttpPost("create-course")]
        public IActionResult CreateCourse(CourseDto addCustomerDto)
        {
            var user = new Course()
            {
                Title = addCustomerDto.Title,
                Description = addCustomerDto.Description,
            };
            applicationDBContext.courses.Add(user);
            applicationDBContext.SaveChanges();
            return Ok(user);
        }
        [HttpPost("create-enrollment")]
        public IActionResult CreateEnrollment(EnrollmentDto addCustomerDto)
        {
            var user = new Enrollment()
            {
                StudentId = addCustomerDto.StudentId,
                CourseId = addCustomerDto.CourseId,
            };
            applicationDBContext.enrollments.Add(user);
            applicationDBContext.SaveChanges();
            return Ok(user);
        }
    }
}
