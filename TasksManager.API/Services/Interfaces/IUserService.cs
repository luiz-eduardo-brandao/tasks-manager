using TasksManager.API.DTOs.Login;

namespace TasksManager.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<LoginResponse> LogIn(LoginRequest request);
    }
}