using Microsoft.EntityFrameworkCore;
using TasksManager.API.Data;
using TasksManager.API.Models;
using TasksManager.API.Repositories.Interfaces;

namespace TasksManager.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<User?> LogIn(string userName, string password) 
        {   
            return await _context.Users.Include(u => u.Collaborator).FirstOrDefaultAsync(u => u.UserName == userName && u.Password == password);  
        }
    }
}