using TasksManager.API.DTOs;
using TasksManager.API.DTOs.TimeTrackers;
using TasksManager.API.Models;

namespace TasksManager.API.Services.Interfaces
{
    public interface ITimeTrackerService
    {
        public Task<TimeTracker> StartTracker(string timezone, StartStopTrackerRequest request);
        public Task StopTracker(Guid timeTrackerId);
        public Task<List<TimeTrackerDTO>> GetAllTrackers();
        public Task<TimeTrackerDTO> GetTrackerById(Guid id);
        public Task<TimeTrackerDTO> AddTracker(string timezone, AddTimeTrackerRequest request);
        public Task<TimeTrackerDTO> UpdateTracker(string timezone, UpdateTimeTrackerRequest request);
        public Task DeleteTracker(Guid id);
    }
}
