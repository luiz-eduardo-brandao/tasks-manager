using System.Globalization;
using TasksManager.API.Models;

namespace TasksManager.API.DTOs
{
    public class TimeTrackerResponse
    {
        public TimeTrackerResponse(TimeTracker timeTracker)
        {
            Id = timeTracker.Id;
            TaskId = timeTracker.TaskId;
            CollaboratorId = timeTracker.CollaboratorId;
            TimeZoneId = timeTracker.TimeZoneId;
            
            var culture = new CultureInfo(timeTracker.TimeZoneId);

            StartDate = timeTracker.StartDate.ToString(culture);
            EndDate = timeTracker.EndDate.ToString(culture);
        }

        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid CollaboratorId { get; set; }
        public string TimeZoneId { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
    }
}