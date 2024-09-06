using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksManager.API.Models;

namespace TasksManager.API.Repositories.Interfaces
{
    public interface IProjectsRepository
    {
        public Task<List<Project>> GetAllProjects();
        public Task<Project?> GetProjectById(Guid id);
        public Task<Project?> AddProject(Project project);
        public Task<Project?> UpdateProject(Project project);
        public Task DeleteProject(Project project);
    }
}