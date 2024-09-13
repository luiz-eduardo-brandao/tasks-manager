using System.ComponentModel.DataAnnotations;

namespace TasksManager.API.DTOs.Projects
{
    public class AddProjectRequest
    {
        [Required(ErrorMessage = "Informe o nome do projeto")]
        public string Name { get; set; }
    }
}
