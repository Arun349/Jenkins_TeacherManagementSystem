using Microsoft.AspNetCore.Mvc;
using Teacher_Management_System.Models;

namespace Teacher_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private static List<TeacherModel> teachers = new List<TeacherModel> { };

        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<TeacherModel> GetTeachers()
        {
            return teachers;
        }

        [HttpPost]
        public IActionResult PostTeachers(TeacherModel teacher)
        {
            teachers.Add(teacher);
            return Ok(teacher);
        }
    }
}
