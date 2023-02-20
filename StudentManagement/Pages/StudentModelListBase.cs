using Microsoft.AspNetCore.Components;
using Shared.Models;

namespace StudentManagement.Pages
{
    public class StudentModelListBase : ComponentBase
    {
        public IEnumerable<StudentModelModel>? StudentsList { get; set; }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

    }
}
