using API.IRepository;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace API.Repository
{
    public class StudentManagerRepository : IStudentManagerRepository
    {
        private readonly AppDbContext _appDbContext;

        public StudentManagerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<StudentModel> AddStudent(StudentModel student)
        {
            var result = await _appDbContext.Students.AddAsync(student);

            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteStudentAsync(int StudentModelModelId)
        {
            var result = await _appDbContext.Students.FirstOrDefaultAsync(s => s.StudentModelID == StudentModelModelId);

            if (result != null)
            {
                _appDbContext.Students.Remove(result);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<StudentModel?> GetStudentById(int StudentModelModelId)
        {
            return await _appDbContext.Students.FirstOrDefaultAsync(s => s.StudentModelID == StudentModelModelId);
        }

        public async Task<StudentModel?> GetStudentByEmail(string Email)
        {
            var student = await _appDbContext.Students.FirstOrDefaultAsync(e => e.Email == Email);

            if (student != null)
            {
                return student;
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<StudentModel>> GetStudents()
        {
            return await _appDbContext.Students.ToListAsync();
        }

        public async Task<StudentModel?> UpdateStudent(StudentModel student)
        {
            var result = await _appDbContext.Students.FirstOrDefaultAsync(s => s.StudentModelID == student.StudentModelID);

            if (result != null) 
            { 
                result.FirstName= student.FirstName;
                result.LastName= student.LastName;
                result.Email= student.Email;
                result.DateOfBrith= student.DateOfBrith;
                result.Gender= student.Gender;
                result.DepartmentId= student.DepartmentId;
                result.Email= student.Email;

                await _appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
