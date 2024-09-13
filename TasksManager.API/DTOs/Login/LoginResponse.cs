using System.Text.Json.Serialization;
using TasksManager.API.DTOs.Base;
using TasksManager.API.Models;

namespace TasksManager.API.DTOs.Login
{
    public class LoginResponse : BaseResponse
    {

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime ExpirationDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string AccessToken { get; set; }

        public User? User { get; set; } 

    }
}