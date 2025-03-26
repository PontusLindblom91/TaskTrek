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

        public async Task<List<ProjectTaskDTO>> GetAllProjectTasks()
        {
            var tasks = await _repo.GetAllProjectTasks();

            var taskDTOs = new List<ProjectTaskDTO>();

            foreach (var task in tasks)
            {
                var dto = new ProjectTaskDTO
                {
                    TaskDescription = task.TaskDescription,
                    TaskStatus = task.TaskStatus,
                    TaskType = task.TaskType,
                    AssignedUser = task.AssignedUser,
                };

                taskDTOs.Add(dto);
            }
            return taskDTOs;
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

        public async Task DeleteProjectTask(int taskId)
        {
            await _repo.DeleteProjectTask(taskId);
        }
    }
}
