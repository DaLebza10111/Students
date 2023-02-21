using Shared.Models;

namespace API.IRepository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department? GetDepartment(int departmentId);
    }
}
