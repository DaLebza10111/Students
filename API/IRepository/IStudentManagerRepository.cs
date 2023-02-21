using Shared.Models;

namespace API.IRepository
{
    public interface IStudentManagerRepository
    {
        Task<IEnumerable<StudentModel>> GetStudents();
        Task<StudentModel?> GetStudent(int StudentModelModelId);
        Task<StudentModel> AddStudent(StudentModel student);
        Task<StudentModel?> UpdateStudent(StudentModel student);
        Task DeleteStudentAsync(int StudentModelModelId);
    }
}
