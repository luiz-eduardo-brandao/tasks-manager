using System.ComponentModel.DataAnnotations;

namespace TasksManager.API.DTOs.Tasks
{
    public class AddTaskRequest
    {
        [Required(ErrorMessage = "Informe o projeto")]
        public Guid ProjectId { get; set; }

        [Required(ErrorMessage = "Informe o nome da task")]
        public string Name { get; set; } = string.Empty;


        [Required(ErrorMessage = "Informe a descrição da task")]
        public string Description { get; set; } = string.Empty;
    }
}
