using Microsoft.EntityFrameworkCore;
using TasksManager.API.Data;
using TasksManager.API.Models;
using TasksManager.API.Repositories.Interfaces;

namespace TasksManager.API.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        private readonly DataContext _context;

        public TasksRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<TaskModel>> GetAllTasks()
        {
            var tasks = await _context.Tasks
                .Include(p => p.TimeTrackers)
                .Where(p => !p.IsDeleted)
                .ToListAsync();

            return tasks;
        }

        public async Task<TaskModel?> GetTaskById(Guid id)
        {
            var task = await _context.Tasks
                .Include(p => p.TimeTrackers)
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id == id);

            return task;
        }

        public async Task<TaskModel?> AddTask(TaskModel task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return await GetTaskById(task.Id);
        }

        public async Task<TaskModel?> UpdateTask(TaskModel task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();

            return await GetTaskById(task.Id);
        }

        public async Task DeleteTask(TaskModel task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }
    }
}
