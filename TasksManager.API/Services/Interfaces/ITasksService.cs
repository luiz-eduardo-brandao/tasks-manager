using TasksManager.API.DTOs.Projects;
using TasksManager.API.DTOs;
using TasksManager.API.DTOs.Tasks;

namespace TasksManager.API.Services.Interfaces
{
    public interface ITasksService
    {
        public Task<List<TaskDTO>> GetAllTasks();
        public Task<TaskDTO> GetTaskById(Guid id);
        public Task<TaskDTO> AddTask(AddTaskRequest request);
        public Task<TaskDTO> UpdateTask(UpdateTaskRequest request);
        public Task DeleteTask(Guid id);
    }
}
