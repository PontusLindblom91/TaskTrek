namespace TaskTrek.Models.Entities
{
    public class ProjectTask
    {
        public int TaskId { get; set; }
        public string TaskType { get; set; }
        public string TaskDescription { get; set; }
        public int AssignedUser { get; set; }
    }
}
