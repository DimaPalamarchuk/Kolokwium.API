using KolokwiumStudent.Entities;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumStudent
{
    public class StudentContextDb : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourseGrade> StudentCourseGrades { get;set; }

        public StudentContextDb(DbContextOptions<StudentContextDb> options) : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                @"server=(localdb)\MSSQLLocalDB;database=course-dev_szk3;trusted_connection=true;",
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "kolokwium")
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.CourseGrades)
                .WithOne()
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
