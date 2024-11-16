using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Exam.Models
{
    public class StudentDto
    {

        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class CourseDto
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class EnrollmentDto
    {
        public int? Id { get; set; }
        
        public int StudentId { get; set; }
        
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
