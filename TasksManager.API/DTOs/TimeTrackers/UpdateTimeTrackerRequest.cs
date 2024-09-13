using System.ComponentModel.DataAnnotations;

namespace TasksManager.API.DTOs.TimeTrackers
{
    public class UpdateTimeTrackerRequest
    {
        [Required(ErrorMessage = "Informe o time tracker")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe a task")]
        public Guid TaskId { get; set; }

        [Required(ErrorMessage = "Informe o colaborador")]
        public Guid CollaboratorId { get; set; }

        [Required(ErrorMessage = "Informe a data de início")]
        public string StartDate { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a data de fim")]
        public string EndDate { get; set; } = string.Empty;
    }
}
