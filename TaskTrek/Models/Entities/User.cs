using System.ComponentModel.DataAnnotations;

namespace TaskTrek.Models.Entities
{
    public class User
    {
        [Key] public int UserID { get; set; }
        public String UserName { get; set; }
    }
}
