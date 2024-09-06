using Microsoft.EntityFrameworkCore;
using TasksManager.API.Data;
using TasksManager.API.Models;
using TasksManager.API.Repositories.Interfaces;

namespace TasksManager.API.Repositories
{
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly DataContext _context;

        public ProjectsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Project>> GetAllProjects() 
        {
            var projects = await _context.Projects
                .Include(p => p.Tasks.Where(t => !t.IsDeleted))
                .Where(p => !p.IsDeleted)
                .ToListAsync();

            return projects;
        }

        public async Task<Project?> GetProjectById(Guid id) 
        {
            var project = await _context.Projects
                .Include(p => p.Tasks.Where(t => !t.IsDeleted))
                .Where(p => !p.IsDeleted)
                .FirstOrDefaultAsync(p => p.Id == id);

            return project;
        }

        public async Task<Project?> AddProject(Project project) 
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            return await GetProjectById(project.Id);
        }

        public async Task<Project?> UpdateProject(Project project) 
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();

            return await GetProjectById(project.Id);
        }

        public async Task DeleteProject(Project project) 
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
        }
    }
}