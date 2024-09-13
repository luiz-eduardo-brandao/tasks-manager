using TasksManager.API.DTOs;
using TasksManager.API.DTOs.TimeTrackers;
using TasksManager.API.Mappings;
using TasksManager.API.Models;
using TasksManager.API.Repositories.Interfaces;
using TasksManager.API.Services.Interfaces;

namespace TasksManager.API.Services
{
    public class TimeTrackerService : ITimeTrackerService
    {
        private readonly ITimeTrackerRepository _timeTrackerRepository;

        public TimeTrackerService(ITimeTrackerRepository timeTrackerRepository)
        {
            _timeTrackerRepository = timeTrackerRepository;
        }

        public async Task<TimeTracker> StartTracker(string timezone, StartStopTrackerRequest request) 
        {
            var timeTracker = new TimeTracker(request.TaskId, request.CollaboratorId, timezone);

            timeTracker.StartDate = DateTime.UtcNow;

            var result = await _timeTrackerRepository.AddAsync(timeTracker);

            if (result == null)
                throw new Exception("Falha ao cadastrar time tracker");

            return result;
        }

        public async Task StopTracker(Guid timeTrackerId)
        {
            var tracker = await _timeTrackerRepository.GetByIdAsync(timeTrackerId);

            if (tracker == null)
                throw new ArgumentException("Esse Time Tracker não existe");

            tracker.Update();
            tracker.EndDate = DateTime.UtcNow;

            var result = await _timeTrackerRepository.UpdateAsync(tracker);

            if (result == null)
                throw new Exception("Falha ao atualizar time tracker");
        }

        public async Task<List<TimeTrackerDTO>> GetAllTrackers()
        {
            var result = await _timeTrackerRepository.GetAllAsync();

            return result.ToTimeTrackerDTOList();
        }

        public async Task<TimeTrackerDTO> GetTrackerById(Guid id)
        {
            var tracker = await _timeTrackerRepository.GetByIdAsync(id);

            if (tracker == null)
                throw new ArgumentException("Time Tracker não encontrado");

            return tracker.ToTimeTrackerDTO();
        }

        public async Task<TimeTrackerDTO> AddTracker(string timezone, AddTimeTrackerRequest request)
        {
            var tracker = new TimeTracker(request.TaskId, request.CollaboratorId, request.StartDate, request.EndDate, timezone);

            await VerifyCollaborator(request.CollaboratorId);
            await VerifyTask(request.TaskId);

            await VerifyTimeTrackerInterval(tracker);

            var newTracker = await _timeTrackerRepository.AddAsync(tracker);

            if (newTracker == null)
                throw new ArgumentException("Falha ao cadastrar novo Time Tracker");

            return newTracker.ToTimeTrackerDTO();
        }
        public async Task<TimeTrackerDTO> UpdateTracker(string timezone, UpdateTimeTrackerRequest request)
        {
            var tracker = await _timeTrackerRepository.GetByIdAsync(request.Id);

            if (tracker == null)
                throw new ArgumentException("Esse Time Tracker não existe");

            await VerifyCollaborator(request.CollaboratorId);
            await VerifyTask(request.TaskId);

            var taskUdpate = request.ToTimeTracker(timezone);

            taskUdpate.Update();

            await VerifyTimeTrackerInterval(tracker);

            var result = await _timeTrackerRepository.UpdateAsync(taskUdpate);

            if (result == null)
                throw new ArgumentException("Falha ao atualizar task");

            return result.ToTimeTrackerDTO();
        }

        public async Task DeleteTracker(Guid id)
        {
            var tracker = await _timeTrackerRepository.GetByIdAsync(id);

            if (tracker is null)
                throw new ArgumentNullException("Time Tracker não encontrado");

            tracker.Delete();

            await _timeTrackerRepository.DeleteAsync(tracker);
        }

        private async Task VerifyCollaborator(Guid id) 
        {
            var collaborator = await _timeTrackerRepository.GetCollaboratorById(id);

            if (collaborator == null)
                throw new ArgumentNullException("Este Colaborador não existe");
        }

        private async Task VerifyTask(Guid id)
        {
            var task = await _timeTrackerRepository.GetTaskById(id);

            if (task == null)
                throw new ArgumentNullException("Esta Task não existe");
        }

        private async Task VerifyTimeTrackerInterval(TimeTracker tracker)
        {
            if (tracker.StartDate.HasValue)
            {
                var result = await _timeTrackerRepository.VerifyTimeTrackerInterval(tracker.TaskModelId, tracker.StartDate.Value);

                if (result is not null)
                    throw new Exception("Já existe um time tracker com esse intervalo de datas");
            }

            if (tracker.EndDate.HasValue) 
            {
                var result = await _timeTrackerRepository.VerifyTimeTrackerInterval(tracker.TaskModelId, tracker.EndDate.Value);

                if (result is not null)
                    throw new Exception("Já existe um time tracker com esse intervalo de datas");
            }
        }
    }
}