using TasksManager.API.DTOs;
using TasksManager.API.DTOs.Projects;
using TasksManager.API.DTOs.Requests;
using TasksManager.API.Models;

namespace TasksManager.API.Mappings
{
    public static class ProjetcMapping
    {
        public static Project ToProject(this ProjectDTO dto) 
        {
            return new Project()
            {
                Id = dto.Id,
                Name = dto.Name,
            };
        }

        public static ProjectDTO ToProjectDTO(this Project project) 
        {
            return new ProjectDTO()
            {
                Id = project.Id,
                Name = project.Name,
                Tasks = project.Tasks.Select(t => t.ToTaskDTO()).ToList()
            };
        }

        public static List<ProjectDTO> ToProjectDTOList(this List<Project> projects) 
        {
            return projects.Select(project => project.ToProjectDTO()).ToList();
        }

        public static Project ToProject(this UpdateProjectRequest request)
        {
            return new Project
            {
                Id = request.Id,
                Name = request.Name
            };
        }
    }
}