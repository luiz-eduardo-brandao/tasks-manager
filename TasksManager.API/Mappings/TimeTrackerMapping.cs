using TasksManager.API.DTOs;
using TasksManager.API.Models;
using System.Globalization;
using TasksManager.API.DTOs.TimeTrackers;

namespace TasksManager.API.Mappings
{
    public static class TimeTrackerMapping
    {
        public static TimeTracker ToTimeTracker(this TimeTrackerDTO dto)
        {
            var culture = new CultureInfo(dto.TimeZoneId);

            return new TimeTracker
            {
                Id = dto.Id,
                TaskModelId = dto.TaskId,
                CollaboratorId = dto.CollaboratorId,
                TimeZoneId = dto.TimeZoneId,
                StartDate = DateTime.Parse(dto.StartDate, culture),
                EndDate = DateTime.Parse(dto.EndDate, culture)
            };
        }

        public static TimeTrackerDTO ToTimeTrackerDTO(this TimeTracker timeTracker)
        {
            var culture = new CultureInfo(timeTracker.TimeZoneId);

            return new TimeTrackerDTO
            {
                Id = timeTracker.Id,
                TaskId = timeTracker.TaskModelId,
                CollaboratorId = timeTracker.CollaboratorId,
                TimeZoneId = timeTracker.TimeZoneId,
                StartDate = timeTracker.StartDate.HasValue ? timeTracker.StartDate.Value.ToString(culture) : null,
                EndDate = timeTracker.EndDate.HasValue ? timeTracker.EndDate.Value.ToString(culture) : null
            };
        }

        public static List<TimeTrackerDTO> ToTimeTrackerDTOList(this List<TimeTracker> timeTrackers)
        {
            return timeTrackers.Select(track => track.ToTimeTrackerDTO()).ToList();
        }

        public static TimeTracker ToTimeTracker(this UpdateTimeTrackerRequest request, string timezone)
        {
            var culture = new CultureInfo(timezone);

            return new TimeTracker
            {
                Id = request.Id,
                TaskModelId = request.TaskId,
                CollaboratorId = request.CollaboratorId,
                TimeZoneId = timezone,
                StartDate = DateTime.Parse(request.StartDate, culture),
                EndDate = DateTime.Parse(request.EndDate, culture)
            };
        }
    }
}
