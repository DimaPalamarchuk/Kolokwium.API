using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumStudent.Entities
{
    [Table("Students", Schema = "Kolokwium")]
    public class Student
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }
        public ICollection<StudentCourseGrade> CourseGrades { get; set; } = new List<StudentCourseGrade>();
    }
}
