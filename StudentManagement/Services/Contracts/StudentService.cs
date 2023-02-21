using Shared.Models;
using StudentManagement.Services.Concretes;
using System.Net.Http.Json;

namespace StudentManagement.Services.Contracts
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _http;

        public StudentService(HttpClient http)
        {
            _http = http;
        }
        public async Task<IEnumerable<StudentModel?>> GetStudentsAsync()
        {
            return await _http.GetFromJsonAsync<StudentModel[]?>("api/Student");
        }
    }
}
