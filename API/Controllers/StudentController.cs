using API.IRepository;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentManagerRepository _studentManager;

        public StudentController(IStudentManagerRepository studentManager)
        {
            _studentManager = studentManager;
        }

        [HttpGet]
        public async Task<ActionResult> GetListofALLStudents()
        {
            var studentlist = await _studentManager.GetStudents();

            if (studentlist != null)
            {
                return Ok(studentlist);
            }
            else
            {
                return NotFound("Cannot retrieve the list of students at the moment.");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<StudentModel>> GetStudentbyID(int id){
            var student = await _studentManager.GetStudent(id);

            if (student != null)
            {
                return student;
            }
            else
            {
                return NotFound($"The requested student: {id} cannot be found.");
            }
        }
    }
}
