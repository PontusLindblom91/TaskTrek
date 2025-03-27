using TaskTrek.Data.Repositories;
using TaskTrek.Models.DTOs;
using TaskTrek.Models.Entities;

namespace TaskTrek.Services
{
    public class SprintService
    {
        private readonly SprintRepo _sprintRepo;
        private readonly ProjectTaskRepo _projectTaskRepo;

        public SprintService(SprintRepo sprintRepo, ProjectTaskRepo projectTaskRepo)
        {
            _sprintRepo = sprintRepo;
            _projectTaskRepo = projectTaskRepo;
        }

        public async Task<List<Sprint>> GetAllSprints()
        {
            var sprints = await _sprintRepo.GetAllSprints();

            return sprints;
        }

        public async Task PostSprint(AddSprintDTO sprintDTO)
        {
            var sprint = new Sprint
            {
                Name = sprintDTO.Name,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };
            await _sprintRepo.PostSprint(sprint);
        }


        public async Task<bool> AddTaskToSprint(int sprintId, int taskId)
        {
            var exists = await _projectTaskRepo.TaskExists(taskId);

            if (exists)
            {
                await _sprintRepo.AddTaskToSprint();
            }
            return false;
        }
    }
}
