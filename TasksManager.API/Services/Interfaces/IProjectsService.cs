using TasksManager.API.DTOs;
using TasksManager.API.DTOs.Projects;

namespace TasksManager.API.Services.Interfaces
{
    public interface IProjectsService
    {
        public Task<List<ProjectDTO>> GetAllProjects();
        public Task<ProjectDTO> GetProjectById(Guid id);
        public Task<ProjectDTO> AddProject(AddProjectRequest request);
        public Task<ProjectDTO> UpdateProject(UpdateProjectRequest request);
        public Task DeleteProject(Guid id);
    }
}