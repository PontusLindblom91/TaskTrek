using Microsoft.EntityFrameworkCore;
using TaskTrek.Models.Entities;


namespace TaskTrek.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Models.Entities.Task> Tasks { get; set; }

    }
}
