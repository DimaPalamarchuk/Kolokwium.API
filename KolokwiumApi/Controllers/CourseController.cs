using KolokwiumApi.Entities;
using KolokwiumApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumApi.Controllers
{
    public class CourseController : ControllerBase
    {
        private readonly CourseService _courseService;

        public CourseController(CourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("courses")]
        public async Task<IEnumerable<Course>> Read() => await _courseService.Get();

        [HttpGet("courses/{id}")]
        public async Task<IActionResult> ReadById(int id)
        {
            var companyDto = await _courseService.GetById(id);

            if (companyDto == null)
            {
                return NotFound();
            }

            return Ok(companyDto);
        }
        [HttpPost("course")]
        public async Task<IActionResult> Create([FromBody] Course dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _courseService.Add(dto);
            return Ok();
        }
    }
}