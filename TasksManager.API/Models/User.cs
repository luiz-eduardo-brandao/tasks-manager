using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TasksManager.API.Models.Base;

namespace TasksManager.API.Models
{
    public class User : BaseEntity
    {        
        // public User()
        // {
            
        // }

        // public User(string userName, string password) : base()
        // {
        //     UserName = userName;
        //     Password = password;
        // }

        [StringLength(250)]
        public string UserName { get; set; } = string.Empty;
        
        [StringLength(512)]
        public string Password { get; set; } = string.Empty;

        public Collaborator Collaborator { get; set; }
    }
}