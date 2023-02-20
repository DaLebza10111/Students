using Shared.Models;

namespace API.Contracts
{
    public interface IStudentManager
    {
        Task<IEnumerable<StudentModelModel>> GetEmployees();
        Task<StudentModelModel> GetEmployee(int StudentModelModelId);
        Task<StudentModelModel> AddEmployee(StudentModelModel student);
        Task<StudentModelModel> UpdateEmployee(StudentModelModel student);
        void DeleteEmployee(int StudentModelModelId);
    }
}
