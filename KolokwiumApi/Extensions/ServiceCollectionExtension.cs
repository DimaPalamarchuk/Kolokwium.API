using KolokwiumApi.Services;

namespace KolokwiumApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCourseServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<CourseContextDb, CourseContextDb>();
            serviceCollection.AddTransient<CourseService>();
            return serviceCollection;
        }
    }
}