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

        public async Task<List<TaskModel>> GetAllAsync()
        {
            var tasks = await _context.Tasks
                .Include(p => p.TimeTrackers.Where(t => !t.IsDeleted))
                .Where(p => !p.IsDeleted)
                .ToListAsync();

            return tasks;
        }

        public async Task<List<TaskModel>> GetAllTasksByProject(Guid projectId)
        {
            var tasks = await _context.Tasks
              .Include(p => p.TimeTrackers.Where(t => !t.IsDeleted))
              .Where(p => !p.IsDeleted && p.ProjectId == projectId)
              .ToListAsync();

            return tasks;
        }
        public async Task<List<TaskModel>> GetAllTasksByCollaborator(Guid id)
        {
            var tasks = await (from ta in _context.Tasks
                         join ti in _context.TimeTrackers on ta.Id equals ti.TaskModelId
                         where ti.CollaboratorId == id && ta.Id == ti.TaskModelId
                         select new TaskModel
                         {
                             Id = ta.Id,
                             ProjectId = ta.ProjectId,
                             Name = ta.Name,
                             Description = ta.Description,
                             TimeTrackers = ta.TimeTrackers,
                         })
                        .ToListAsync();

            return tasks;
        }        

        public async Task<TaskModel?> GetByIdAsync(Guid id)
        {
            var task = await _context.Tasks
                .Include(p => p.TimeTrackers.Where(t => !t.IsDeleted))
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id == id);

            return task;
        }

        public async Task<TaskModel?> AddAsync(TaskModel task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return await GetByIdAsync(task.Id);
        }

        public async Task<TaskModel?> UpdateAsync(TaskModel task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();

            return await GetByIdAsync(task.Id);
        }

        public async Task DeleteAsync(TaskModel task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }
    }
}
