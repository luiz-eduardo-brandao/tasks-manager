using TasksManager.API.Models;

namespace TasksManager.API.Repositories.Interfaces
{
    public interface ITasksRepository
    {
        public Task<List<TaskModel>> GetAllTasks();
        public Task<TaskModel?> GetTaskById(Guid id);
        public Task<TaskModel?> AddTask(TaskModel task);
        public Task<TaskModel?> UpdateTask(TaskModel task);
        public Task DeleteTask(TaskModel task);
    }
}
