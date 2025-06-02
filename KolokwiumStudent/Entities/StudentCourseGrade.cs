using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumStudent.Entities
{
    [Table("StudentCourseGrades", Schema = "Kolokwium")]
    public class StudentCourseGrade
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public int CourseExternalId { get; set; }
        public string? CourseName { get; set; }

        [Range(2,5)]
        public decimal Grade { get; set; }
    }
}
