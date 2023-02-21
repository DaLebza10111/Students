using Microsoft.AspNetCore.Components;
using Shared.Models;
using StudentManagement.Services.Concretes;

namespace StudentManagement.Pages
{
    public class StudentModelListBase : ComponentBase
    {
        [Inject]
        public IStudentService? studentService { get; set; }
        public IEnumerable<StudentModel>? StudentsList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            StudentsList = (await studentService.GetStudentsAsync()).ToList();
        }

    }
}
