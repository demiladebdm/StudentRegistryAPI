using NotificationService.Interfaces;
using NotificationService.Utilities;

namespace NotificationService.Configurations
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddNotificationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();
            //services.AddHttpClient<HttpService>();

            //services
            //services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>));

            services.AddScoped<IOTPGenerator, OTPGenerator>();
            services.AddScoped<INotificationService, Services.NotificationService>();

            return services;
        }
    }
}
