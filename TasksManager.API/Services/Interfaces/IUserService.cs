using TasksManager.API.DTOs.Requests;
using TasksManager.API.DTOs.Responses;

namespace TasksManager.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<LoginResponse> LogIn(LoginRequest request);
    }
}