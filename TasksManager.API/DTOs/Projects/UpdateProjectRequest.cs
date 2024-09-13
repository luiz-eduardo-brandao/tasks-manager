using System.ComponentModel.DataAnnotations;

namespace TasksManager.API.DTOs.Projects
{
    public class UpdateProjectRequest
    {
        [Required(ErrorMessage = "Informe o projeto")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do projeto")]
        public string Name { get; set; }
    }
}
