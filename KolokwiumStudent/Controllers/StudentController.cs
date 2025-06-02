using KolokwiumStudent.Entities;
using KolokwiumStudent.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumStudent.Controllers
{
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("students")]
        public async Task<ActionResult<IEnumerable<Student>>> GetAll()
        {
            var students = await _studentService.Get();
            return Ok(students);
        }

        [HttpGet("student/{id}")]
        public async Task<ActionResult<Student>> GetById(int id)
        {
            var student = await _studentService.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost("students")]
        public async Task<IActionResult> Create([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _studentService.Add(student);
            return CreatedAtAction(nameof(GetById), new {id = student.Id}, student);
        }
    }
}
