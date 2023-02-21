using Shared.Models;

namespace StudentManagement.Services.Concretes
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentModel?>> GetStudentsAsync();
    }
}
