using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KolokwiumApi.Entities
{
    [Table("Courses", Schema = "kolokwium")]
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        public int NumberOfHours { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
