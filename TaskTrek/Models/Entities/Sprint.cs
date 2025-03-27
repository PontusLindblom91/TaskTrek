using TaskTrek.Models.DTOs;

namespace TaskTrek.Models.Entities
{
    public class Sprint
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<int> TaskIds { get; set; } = new();
    }

}
