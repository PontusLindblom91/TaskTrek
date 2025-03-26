using System.ComponentModel.DataAnnotations;

namespace TaskTrek.Models.DTOs
{
    public class ProjectTaskDTO
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public string TaskType { get; set; }
        public string TaskStatus { get; set; }
        public int AssignedUser { get; set; }
    }
}
