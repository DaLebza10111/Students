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
        public async Task<ActionResult<StudentModel>> GetStudentbyID(int id) {
            var student = await _studentManager.GetStudentById(id);

            if (student != null)
            {
                return student;
            }
            else
            {
                return NotFound($"The requested student: {id} cannot be found.");
            }
        }
        [HttpGet("{email:email}")]
        public async Task<ActionResult<StudentModel>> GetStudentbyEmail(string email) {
            var student = await _studentManager.GetStudentByEmail(email);

            if (student != null)
            {
                return student;
            }
            else
            {
                return NotFound($"The requested student: {email} cannot be found.");
            }
        }
        [HttpPost]
        public async Task<ActionResult<StudentModel>> RegisterNewStudent([FromBody] StudentModel student)
        {
            if (student != null)
            {
                var newstudent = await _studentManager.AddStudent(student);

                return CreatedAtAction(nameof(GetStudentbyID), new { id = newstudent.StudentModelID }, newstudent);
            }
            else
            {
                return NotFound($"Cannot register {student?.FirstName} at the moment.");
            }
        }
        [HttpPut]
        public async Task<ActionResult<StudentModel?>> UpdateStudentDetails(int id, StudentModel studentModel)
        {
            if (id != studentModel.StudentModelID)
            {
                return BadRequest("Student ID mismatch!");
            }
            else
            {
                var studentupdate = await _studentManager.GetStudentById(id);

                if (studentupdate != null)
                {
                    return await _studentManager.UpdateStudent(studentModel);
                }
                return BadRequest("Student ID not found!");
            }
        }
        [HttpDelete("{int:id}")]
        public async Task DeleteStudentById(int id)
        {
            var removestudent = await _studentManager.GetStudentById(id);

            if (removestudent != null)
            {
                await _studentManager.DeleteStudentAsync(removestudent.StudentModelID);
            }
            else
            {
                NotFound($"Employee {id} not found!");
            }
        }
    }
}
