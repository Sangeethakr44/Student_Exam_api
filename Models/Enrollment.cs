using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Exam.Models
{
    public class Enrollment
    {

        public int Id { get; set; }
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public DateTime EnrollmentDate {  get; set; }
    }
}
