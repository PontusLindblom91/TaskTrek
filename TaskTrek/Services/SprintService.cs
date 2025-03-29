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


        public async Task<bool> AddTaskToSprint(Guid sprintId, int taskId)
        {
            var task = await _projectTaskRepo.TaskExists(taskId);
            if (!task)   
                return false;
            var sprint = await _sprintRepo.FindSprint(sprintId);
            if (sprint == null)
                return false;
            if (!sprint.TaskIds.Contains(taskId))
            {
                sprint.TaskIds.Add(taskId);
            }
            await _sprintRepo.AddTaskToSprint(sprint);
            return true;
        }
    }
}
