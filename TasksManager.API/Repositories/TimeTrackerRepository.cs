using Microsoft.EntityFrameworkCore;
using TasksManager.API.Data;
using TasksManager.API.Models;
using TasksManager.API.Repositories.Interfaces;

namespace TasksManager.API.Repositories
{
    public class TimeTrackerRepository : ITimeTrackerRepository
    {
        private readonly DataContext _context;
        private readonly ITasksRepository _taskRepository;

        public TimeTrackerRepository(DataContext context, ITasksRepository taskRepository)
        {
            _context = context;
            _taskRepository = taskRepository;
        }

        public async Task<TimeTracker?> VerifyTimeTrackerInterval(Guid taskId, DateTime date)
        {
            var result = await _context.TimeTrackers
                .SingleOrDefaultAsync(t => t.TaskModelId == taskId
                && (
                    (t.StartDate >= date && date <= t.EndDate) || (t.EndDate >= date && date <= t.EndDate)
                ));

            return result;
        }

        public async Task<Collaborator?> GetCollaboratorById(Guid id)
        {
            return await _context.Collaborators.SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<TaskModel?> GetTaskById(Guid id)
        {
            return await _taskRepository.GetByIdAsync(id);
        }

        public async Task<List<TimeTracker>> GetAllAsync()
        {
            var trackers = await _context.TimeTrackers
                .Where(p => !p.IsDeleted)
                .ToListAsync();

            return trackers;
        }

        public async Task<TimeTracker?> GetByIdAsync(Guid id)
        {
            var tracker = await _context.TimeTrackers
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id == id);

            return tracker;
        }

        public async Task<TimeTracker?> AddAsync(TimeTracker tracker)
        {
            _context.TimeTrackers.Add(tracker);
            await _context.SaveChangesAsync();

            return await GetByIdAsync(tracker.Id);
        }

        public async Task<TimeTracker?> UpdateAsync(TimeTracker tracker)
        {
            _context.TimeTrackers.Update(tracker);
            await _context.SaveChangesAsync();

            return await GetByIdAsync(tracker.Id);
        }

        public async Task DeleteAsync(TimeTracker tracker)
        {
            _context.TimeTrackers.Update(tracker);
            await _context.SaveChangesAsync();
        }
    }
}
