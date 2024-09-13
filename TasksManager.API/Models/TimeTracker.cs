using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using TasksManager.API.Models.Base;

namespace TasksManager.API.Models
{
    public class TimeTracker : BaseEntity
    {
        public TimeTracker()
        {
            
        }

        public TimeTracker(Guid taskId, Guid collaboratorId, string timeZoneId) : base()
        {
            var culture = new CultureInfo(timeZoneId);

            TaskModelId = taskId;
            CollaboratorId = collaboratorId;
            TimeZoneId = timeZoneId;
        }

        public TimeTracker(Guid taskId, Guid collaboratorId, string startDate, string endDate, string timeZoneId) : base()
        {
            var culture = new CultureInfo(timeZoneId);

            TaskModelId = taskId;
            CollaboratorId = collaboratorId;
            StartDate = DateTime.Parse(startDate, culture);
            EndDate = DateTime.Parse(endDate, culture);
            TimeZoneId = timeZoneId;
        }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        
        [StringLength(200)]
        public string TimeZoneId { get; set; } = string.Empty;
        
        [ForeignKey("TaskId")]
        [Column("TaskId")]
        public Guid TaskModelId { get; set; }

        [ForeignKey("CollaboratorId")]
        public Guid CollaboratorId { get; set; }
    }
}