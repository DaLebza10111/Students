using Microsoft.AspNetCore.Components;
using Shared.Models;

namespace StudentManagement.Pages
{
    public class StudentModelListBase : ComponentBase
    {
        public IEnumerable<StudentModel>? StudentsList { get; set; }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

    }
}
