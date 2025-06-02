using KolokwiumApi.Entities;
using Microsoft.EntityFrameworkCore;


namespace KolokwiumApi
{
    public class CourseContextDb : DbContext
    {
        private IConfiguration _configuration { get; }

        public DbSet<Course> Courses { get; set; }

        public CourseContextDb(IConfiguration configuration)
            : base()
        {
            _configuration = configuration;
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
            base.OnModelCreating(modelBuilder);
        }
    }
}
