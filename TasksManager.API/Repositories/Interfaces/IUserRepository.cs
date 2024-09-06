using TasksManager.API.Models;

namespace TasksManager.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> LogIn(string userName, string password);
    }
}