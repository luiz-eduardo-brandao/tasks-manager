using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TasksManager.API.Models.Base;

namespace TasksManager.API.Models
{
    public class TimeTracker : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        [StringLength(200)]
        public string TimeZoneId { get; set; } = string.Empty;
        
        [ForeignKey("TaskId")]
        public Guid TaskId { get; set; }

        [ForeignKey("CollaboratorId")]
        public Guid CollaboratorId { get; set; }
    }
}