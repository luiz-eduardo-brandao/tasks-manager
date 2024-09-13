namespace TasksManager.API.DTOs.Base
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; } = string.Empty;
    }
}