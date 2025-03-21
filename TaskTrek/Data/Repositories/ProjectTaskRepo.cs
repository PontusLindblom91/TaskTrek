using TaskTrek.Data.Context;
using TaskTrek.Models.DTOs;
using TaskTrek.Models.Entities;

namespace TaskTrek.Data.Repositories
{
    public class ProjectTaskRepo
    {
    private readonly ApplicationDbContext _context;

        public ProjectTaskRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InsertProjectTask(ProjectTask task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }
    }
}
