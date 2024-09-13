using TasksManager.API.Models;
using TasksManager.API.Repositories.Interfaces.Base;

namespace TasksManager.API.Repositories.Interfaces
{
    public interface ITasksRepository : IRepositoryBase<TaskModel>
    {
        public Task<List<TaskModel>> GetAllTasksByProject(Guid projectId);
        public Task<List<TaskModel>> GetAllTasksByCollaborator(Guid id);
    }
}
