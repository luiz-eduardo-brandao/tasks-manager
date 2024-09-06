using TasksManager.API.DTOs;
using TasksManager.API.DTOs.Projects;
using TasksManager.API.DTOs.Tasks;
using TasksManager.API.Models;

namespace TasksManager.API.Mappings
{
    public static class TaskMapping
    {
        public static TaskModel ToTaskModel(this TaskDTO taskDTO) 
        {
            return new TaskModel
            {
                Id = taskDTO.Id,
                ProjectId = taskDTO.ProjectId,
                Name = taskDTO.Name,
                Description = taskDTO.Description
            };
        }

        public static TaskDTO ToTaskDTO(this TaskModel task)
        {
            return new TaskDTO
            {
                Id = task.Id,
                ProjectId = task.ProjectId,
                Name = task.Name,
                Description = task.Description
            };
        }

        public static List<TaskDTO> ToTaskDTOList(this List<TaskModel> tasks)
        {
            return tasks.Select(task => task.ToTaskDTO()).ToList();
        }

        public static TaskModel ToTaskModel(this UpdateTaskRequest request)
        {
            return new TaskModel
            {
                Id = request.Id,
                ProjectId = request.ProjectId,
                Name = request.Name,
                Description = request.Description
            };
        }
    }
}
