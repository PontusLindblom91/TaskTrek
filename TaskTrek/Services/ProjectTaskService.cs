using TaskTrek.Models.DTOs;
using TaskTrek.Models.Entities;
using TaskTrek.Data;
using TaskTrek.Data.Repositories;

namespace TaskTrek.Services
{
    public class ProjectTaskService
    {
        private readonly ProjectTaskRepo _repo;
        private readonly UserRepo _userRepo;

        public ProjectTaskService(ProjectTaskRepo repo, UserRepo userRepo)
        {
            _repo = repo;
            _userRepo = userRepo;
        }

        public async Task<List<ProjectTaskDTO>> GetAllProjectTasks()
        {
            var tasks = await _repo.GetAllProjectTasks();

            var taskDTOs = new List<ProjectTaskDTO>();

            foreach (var task in tasks)
            {
                var user = await _userRepo.GetUserById(task.AssignedUser);

                var dto = new ProjectTaskDTO
                {
                    TaskDescription = task.TaskDescription,
                    TaskStatus = task.TaskStatus,
                    TaskType = task.TaskType,
                    AssignedUser = user,
                };

                taskDTOs.Add(dto);
            }
            return taskDTOs;
        }


        public async Task InsertProjectTask(ProjectTaskDTO taskDto)
        {
            var user = await _userRepo.GetUserByUserName(taskDto.AssignedUser);

            var task = new ProjectTask
            {
                TaskDescription = taskDto.TaskDescription,
                TaskType = taskDto.TaskType,
                AssignedUser = user,
                TaskStatus= taskDto.TaskStatus,
            };

            await _repo.InsertProjectTask(task);
        }

        public async Task DeleteProjectTask(int taskId)
        {
            await _repo.DeleteProjectTask(taskId);
        }
    }
}
