using Microsoft.AspNetCore.Components;
using Shared.Models;

namespace StudentManagement.Pages
{
    public class StudentModelListBase : ComponentBase
    {
        public IEnumerable<StudentModelModel>? StudentsList { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadStudentModels();
            return base.OnInitializedAsync();
        }

        private void LoadStudentModels()
        {
            StudentModelModel e1 = new StudentModelModel
            {
                StudentModelID = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/john.png"
            };

            StudentModelModel e2 = new StudentModelModel
            {
                StudentModelID = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
                PhotoPath = "images/sam.jpg"
            };

            StudentModelModel e3 = new StudentModelModel
            {
                StudentModelID = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/mary.png"
            };

            StudentModelModel e4 = new StudentModelModel
            {
                StudentModelID = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 3, DepartmentName = "Payroll" },
                PhotoPath = "images/sara.png"
            };

            StudentsList = new List<StudentModelModel> { e1, e2, e3, e4 };
        }
    }
}
