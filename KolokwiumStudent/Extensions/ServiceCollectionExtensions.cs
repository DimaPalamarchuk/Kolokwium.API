using KolokwiumStudent.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace KolokwiumStudent.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddStudentServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<StudentContextDb, StudentContextDb>();
            serviceCollection.AddTransient<StudentService>();
            return serviceCollection;
        }
    }
}
