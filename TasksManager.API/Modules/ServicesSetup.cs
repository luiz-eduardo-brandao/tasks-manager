using TasksManager.API.Repositories;
using TasksManager.API.Repositories.Interfaces;
using TasksManager.API.Services;
using TasksManager.API.Services.Interfaces;

namespace TasksManager.API.Modules
{
    public static class ServicesSetup
    {
        public static IServiceCollection AddServicesSetup(this IServiceCollection services) 
        {
            services
                .AddRepositories()
                .AddServices();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProjectsRepository, ProjectsRepository>();
            services.AddScoped<ITasksRepository, TasksRepository>();

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProjectsService, ProjectsService>();
            services.AddScoped<ITasksService, TasksService>();

            return services;
        }
    }
}