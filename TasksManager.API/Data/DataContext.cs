using Microsoft.EntityFrameworkCore;
using TasksManager.API.Models;

namespace TasksManager.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Collaborator> Collaborators { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<TimeTracker> TimeTrackers { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            var userId = Guid.NewGuid();

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId,
                CreatedAt = DateTime.UtcNow,
                UserName = "Edu Brandão",
                Password = "123@Test"
            });
            
            modelBuilder.Entity<Collaborator>().HasData(new Collaborator
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                CreatedAt = DateTime.UtcNow,
                Name = "Edu Brandão",
            });

            var projectId = Guid.NewGuid();

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = projectId,
                CreatedAt = DateTime.UtcNow,
                Name = "Projeto Validações",
            });

            modelBuilder.Entity<TaskModel>().HasData(new TaskModel
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                Name = "Levantamento de Requisitos",
                Description = "Levantamento de Requisitos da demanda",
                ProjectId = projectId
            });
            modelBuilder.Entity<TaskModel>().HasData(new TaskModel
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                Name = "Análise da demanada",
                Description = "Analisando atividades da demanda",
                ProjectId = projectId
            });
            modelBuilder.Entity<TaskModel>().HasData(new TaskModel
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                Name = "Desenvolvimento atividade 1",
                Description = "Desenvolver tela para cadastro de usuários",
                ProjectId = projectId
            });
        }
    }
}