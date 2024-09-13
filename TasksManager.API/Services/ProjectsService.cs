using TasksManager.API.DTOs;
using TasksManager.API.Models;
using TasksManager.API.Mappings;
using TasksManager.API.Repositories.Interfaces;
using TasksManager.API.Services.Interfaces;
using TasksManager.API.DTOs.Projects;

namespace TasksManager.API.Services
{
    public class ProjectsService : IProjectsService
    {
        private readonly IProjectsRepository _projectsRepository;

        public ProjectsService(IProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }

        public async Task<List<ProjectDTO>> GetAllProjects() 
        {
            var projects = await _projectsRepository.GetAllAsync();

            return projects.ToProjectDTOList();
        }

        public async Task<ProjectDTO> GetProjectById(Guid id) 
        {
            var project = await _projectsRepository.GetByIdAsync(id);

            if (project == null)
                throw new ArgumentException("Projeto não encontrado");

            return project.ToProjectDTO();
        }

        public async Task<ProjectDTO> AddProject(AddProjectRequest request) 
        {
            var project = new Project(request.Name);

            var newProject = await _projectsRepository.AddAsync(project);

            if (newProject == null)
                throw new ArgumentException("Falha ao cadastrar projeto");

            return newProject.ToProjectDTO();
        }

        public async Task<ProjectDTO> UpdateProject(UpdateProjectRequest request) 
        {
            var project = await _projectsRepository.GetByIdAsync(request.Id);
            
            if (project == null)
                throw new ArgumentException("Este projeto não existe");

            var projectUpdate = request.ToProject();

            projectUpdate.Update();

            var result = await _projectsRepository.UpdateAsync(projectUpdate);

            if (result == null)
                throw new ArgumentException("Falha ao atualizar projeto");

            return result.ToProjectDTO();
        }

        public async Task DeleteProject(Guid id) 
        {
            var project = await _projectsRepository.GetByIdAsync(id);

            if (project is null)
                throw new ArgumentNullException("Projeto não encontrado");

            project.Delete();

            await _projectsRepository.DeleteAsync(project);
        }
    }
}