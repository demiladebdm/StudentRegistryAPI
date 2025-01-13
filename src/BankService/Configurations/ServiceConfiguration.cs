using BankService.Interfaces;

namespace BankService.Configurations
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddBankServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();
            //services.AddHttpClient<HttpService>();

            // Register HttpClient and configure it using appsettings.json
            services.AddHttpClient<IBankService, Services.BankService>(client =>
            {
                // Get the base address from appsettings.json
                client.BaseAddress = new Uri(configuration["BankService:BaseUrl"]);  // Example configuration key
                client.DefaultRequestHeaders.Add("Accept", "application/json");  // Optional: setting default headers
            });

            //services
            //services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>));

            services.AddScoped<IBankService, Services.BankService>();

            return services;
        }
    }
}
