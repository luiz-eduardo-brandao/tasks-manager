using System.ComponentModel.DataAnnotations;

namespace TasksManager.API.DTOs.Requests
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Password { get; set; }
    }
}