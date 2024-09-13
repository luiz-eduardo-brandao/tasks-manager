using TasksManager.API.DTOs;
using TasksManager.API.DTOs.Tasks;

namespace TasksManager.API.Services.Interfaces
{
    public interface ITasksService
    {
        public Task<List<TaskDTO>> GetAllTasks();
        public Task<List<TaskDTO>> GetAllTasksByProject(Guid projectId);
        public Task<List<TaskDTO>> GetAllTasksByCollaborator(Guid Id);
        public Task<TaskDTO> GetTaskById(Guid id);
        public Task<TaskDTO> AddTask(AddTaskRequest request);
        public Task<TaskDTO> UpdateTask(UpdateTaskRequest request);
        public Task DeleteTask(Guid id);
    }
}
