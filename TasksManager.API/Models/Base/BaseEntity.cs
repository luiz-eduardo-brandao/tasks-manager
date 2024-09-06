using System.ComponentModel.DataAnnotations;

namespace TasksManager.API.Models.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }

        public void Update() 
        {
            UpdatedAt = DateTime.UtcNow;
        }

        public void Delete() 
        {
            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
        }


        [Key]
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}