using BankService.Configurations;
using NotificationService.Configurations;
using StudentService.Interfaces;
using StudentService.Services;
using StudentService.Utilities;

namespace StudentService.Configurations
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();
            //services.AddHttpClient<HttpService>();

            //Microservices
            // Register IOTPGenerator and its implementation
            services.AddNotificationServices(configuration);
            services.AddBankServices(configuration);

            //services
            //services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>));

            services.AddScoped<IStudentService, Services.StudentService>();
            services.AddScoped<IStateLGAService, StateLGAService>();
            services.AddScoped<IStateLGAValidator, StateLGAValidator>();

            return services;
        }
    }
}
