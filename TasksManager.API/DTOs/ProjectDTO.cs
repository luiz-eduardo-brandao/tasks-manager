namespace TasksManager.API.DTOs
{
    public class ProjectDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<TaskDTO> Tasks { get; set; } = new List<TaskDTO>();
    }
}