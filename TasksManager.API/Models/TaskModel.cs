using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TasksManager.API.Models.Base;

namespace TasksManager.API.Models
{
    public class TaskModel : BaseEntity
    {
        public TaskModel()
        {
            
        }

        public TaskModel(Guid projectId, string name, string description) : base()
        {
            ProjectId = projectId;
            Name = name;
            Description = description;
        }

        [StringLength(250)]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [ForeignKey("ProjectId")] 
        public Guid ProjectId { get; set; }

        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]

        public List<TimeTracker> TimeTrackers { get; set; }
    }
}