using Shared.Models;

namespace API.IRepository
{
    public interface IStudentManagerRepository
    {
        Task<IEnumerable<StudentModelModel>> GetStudents();
        Task<StudentModelModel?> GetStudent(int StudentModelModelId);
        Task<StudentModelModel> AddStudent(StudentModelModel student);
        Task<StudentModelModel?> UpdateStudent(StudentModelModel student);
        Task DeleteStudentAsync(int StudentModelModelId);
    }
}
