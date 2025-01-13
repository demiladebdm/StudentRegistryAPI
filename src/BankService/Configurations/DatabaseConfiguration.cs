using Microsoft.EntityFrameworkCore;
using BankService.Data;
using System;

namespace BankService.Configurations
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");

            // Configure DbContext with SQL Server
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            return services;
        }

        public static IHost DbMigration(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var logger = scope.ServiceProvider.GetService<ILogger<IHost>>();
            try
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.Migrate();

                //SyncPermissions(dbContext, logger);
                //SyncAggregators(dbContext, logger, scope);
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, "An error occurred during database migration.");
            }
            return host;
        }
    }
}
