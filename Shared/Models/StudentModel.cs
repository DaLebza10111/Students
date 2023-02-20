using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class StudentModelModel
    {
        public int StudentModelID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public string DepartmentId { get; set; }
        public string? PhotoPath { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
