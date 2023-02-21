using Shared.Models;

namespace API.IRepository
{
    public interface IStudentManagerRepository
    {
        Task<IEnumerable<StudentModel>> GetStudents();
        Task<StudentModel?> GetStudentById(int StudentModelModelId);
        Task<StudentModel> AddStudent(StudentModel student);
        Task<StudentModel?> UpdateStudent(StudentModel student);
        Task<StudentModel?> GetStudentByEmail(string Email);
        Task DeleteStudentAsync(int StudentModelModelId);
    }
}
