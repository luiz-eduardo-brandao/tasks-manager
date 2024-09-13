namespace TasksManager.API.DTOs
{
    public class TaskDTO
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? TotalTimeDay { get; set; }
        public DateTime? TotalTimeMonth { get; set; }
        public List<TimeTrackerDTO> TimeTrackers { get; set; } = new List<TimeTrackerDTO>();
    }
}
