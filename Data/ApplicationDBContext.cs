using Microsoft.EntityFrameworkCore;
using Student_Exam.Models;

namespace Student_Exam.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Student>students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }

    }
}
