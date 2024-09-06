namespace TasksManager.API.DTOs.Tasks
{
    public class AddTaskRequest
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
