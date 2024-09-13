using System.ComponentModel.DataAnnotations;

namespace TasksManager.API.DTOs.Tasks
{
    public class UpdateTaskRequest
    {
        [Required(ErrorMessage = "Informe a task")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe o projeto")]
        public Guid ProjectId { get; set; }

        [Required(ErrorMessage = "Informe o nome da task")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a descrição da task")]
        public string Description { get; set; } = string.Empty;
    }
}
