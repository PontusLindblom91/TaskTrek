namespace TaskTrek.Models.DTOs
{
    public class AddSprintDTO
    {
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
