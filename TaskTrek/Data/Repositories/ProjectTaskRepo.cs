using Microsoft.EntityFrameworkCore;
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

        public async Task<List<ProjectTask>> GetAllProjectTasks()
        {
            var tasks = await _context.ProjectTasks.ToListAsync();

            return tasks;
        }

        public async Task InsertProjectTask(ProjectTask task)
        {
            await _context.ProjectTasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProjectTask(int taskId)
        {
            await _context.ProjectTasks
                .Where(pt => pt.TaskId == taskId)
                .ExecuteDeleteAsync();
        }
    }
}
