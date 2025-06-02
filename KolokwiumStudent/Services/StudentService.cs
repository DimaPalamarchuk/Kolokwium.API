using KolokwiumStudent.Entities;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumStudent.Services
{
    public class StudentService
    {
        private readonly StudentContextDb _context;
        public StudentService(StudentContextDb context)
        {
            _context = context;
        }

        public async Task<Student> GetById(int id)
        {
            return await _context.Students
                .Include(s => s.CourseGrades)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Student>> Get()
        {
            return await _context.Students
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task Add(Student entity)
        {
            _context.Students.Add(entity);
            await _context.SaveChangesAsync();
        }

    }
}
