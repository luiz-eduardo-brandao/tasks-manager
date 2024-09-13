namespace TasksManager.API.DTOs
{
    public class TimeTrackerDTO
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid CollaboratorId { get; set; }
        public string TimeZoneId { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
    }
}
