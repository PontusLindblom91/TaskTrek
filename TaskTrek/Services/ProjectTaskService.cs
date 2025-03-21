using TaskTrek.Models.DTOs;
using TaskTrek.Models.Entities;
using TaskTrek.Data;
using TaskTrek.Data.Repositories;

namespace TaskTrek.Services
{
    public class ProjectTaskService
    {
        private readonly ProjectTaskRepo _repo;

        public ProjectTaskService(ProjectTaskRepo repo)
        {
            _repo = repo;
        }

        public async Task InsertProjectTask(ProjectTaskDTO taskDto)
        {
            var task = new ProjectTask
            {
                TaskDescription = taskDto.TaskDescription,
                TaskType = taskDto.TaskType,
                AssignedUser = taskDto.AssignedUser,
            };

            await _repo.InsertProjectTask(task);
        }
    }
}
