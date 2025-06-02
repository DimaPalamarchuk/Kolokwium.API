using KolokwiumApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumApi.Services
{
    public class CourseService
    {
        private CourseContextDb _context;

        public CourseService(CourseContextDb context)
        {
            _context = context;
        }

        public async Task<Course> GetById(int id)
        {
            return await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Course>> Get()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task Add(Course entity)
        {
            _context.Set<Course>().Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
