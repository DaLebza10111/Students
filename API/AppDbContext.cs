using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }
        public DbSet<StudentModelModel> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
