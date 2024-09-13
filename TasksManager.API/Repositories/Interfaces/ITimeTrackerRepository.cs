using TasksManager.API.Models;
using TasksManager.API.Repositories.Interfaces.Base;

namespace TasksManager.API.Repositories.Interfaces
{
    public interface ITimeTrackerRepository : IRepositoryBase<TimeTracker>
    {
        public Task<Collaborator?> GetCollaboratorById(Guid id);
        public Task<TaskModel?> GetTaskById(Guid id);
        Task<TimeTracker?> VerifyTimeTrackerInterval(Guid taskId, DateTime date);
    }
}
