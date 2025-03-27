using Microsoft.EntityFrameworkCore;
using TaskTrek.Data.Context;
using TaskTrek.Models.Entities;

namespace TaskTrek.Data.Repositories
{
    public class SprintRepo
    {
        private readonly ApplicationDbContext _context;

        public SprintRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Sprint>> GetAllSprints()
        {
            var sprints = await _context.Sprints.ToListAsync();

            return sprints;
        }

        public async Task PostSprint(Sprint sprint)
        {
            await _context.Sprints.AddAsync(sprint);
            await _context.SaveChangesAsync();
        }

        public async Task AddTaskToSprint(Sprint sprint)
        {
            _context.Sprints.Update(sprint);
            await _context.SaveChangesAsync();
        }

        public async Task<Sprint> FindSprint(int sprintId)
        {
            var sprint = await _context.Sprints.FindAsync(sprintId);

            return sprint;
        }
    }
}
