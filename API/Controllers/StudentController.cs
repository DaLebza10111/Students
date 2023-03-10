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
        [HttpPost]
        public async Task<ActionResult<StudentModel>> RegisterNewStudent([FromBody]StudentModel student)
        {
            if (student != null)
            {
                var newstudent = await _studentManager.AddStudent(student);

                return CreatedAtAction(nameof(GetStudentbyID), new {id = newstudent.StudentModelID}, newstudent);
            }
            else
            {
                return NotFound($"Cannot register {student?.FirstName} at the moment.");
            }
        }
    }
}
