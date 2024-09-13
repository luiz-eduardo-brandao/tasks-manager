using System.ComponentModel.DataAnnotations;

namespace TasksManager.API.DTOs.TimeTrackers
{
    public class StartStopTrackerRequest
    {
        [Required(ErrorMessage = "Task não informada")]
        public Guid TaskId { get; set; }

        [Required(ErrorMessage = "Colaborador não informado")]
        public Guid CollaboratorId { get; set; }
    }
}
