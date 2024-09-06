using ApplicationSecretKeys;
using Microsoft.EntityFrameworkCore;
using TasksManager.API.Data;

namespace TasksManager.API.Modules
{
    public static class DataContextSetup
    {
        public static IServiceCollection AddDataContext(this IServiceCollection services) 
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(DataBaseAccessValues.ConnectionString);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            return services;
        }
    }
}