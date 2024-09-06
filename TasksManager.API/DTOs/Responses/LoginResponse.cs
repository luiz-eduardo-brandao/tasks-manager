using System.Text.Json.Serialization;
using TasksManager.API.DTOs.Responses.Base;

namespace TasksManager.API.DTOs.Responses
{
    public class LoginResponse : BaseResponse
    {
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime ExpirationDate { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string AccessToken { get; set; }
        
    }
}