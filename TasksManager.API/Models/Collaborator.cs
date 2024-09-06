using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TasksManager.API.Models.Base;

namespace TasksManager.API.Models
{
    public class Collaborator : BaseEntity
    {
        [StringLength(250)]
        public string Name { get; set; } = string.Empty;
        
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        public List<TimeTracker> TimeTrackers { get; set; }
    }
}