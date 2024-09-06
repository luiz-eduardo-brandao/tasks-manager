using System.ComponentModel.DataAnnotations;
using TasksManager.API.Models.Base;

namespace TasksManager.API.Models
{
    public class Project : BaseEntity
    {
        public Project()
        {
            
        }

        public Project(string name) : base()
        {
            Name = name;
        }

        [StringLength(250)]
        public string Name { get; set; } = string.Empty;

        public List<TaskModel> Tasks { get; set; }

    }
}