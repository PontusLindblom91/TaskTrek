using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskTrek.Models.DTOs;
using TaskTrek.Services;

namespace TaskTrek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTaskController : ControllerBase
    {
        private readonly ProjectTaskService _taskService;

        public ProjectTaskController(ProjectTaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTasks()
        {
            var tasks = await _taskService.GetAllProjectTasks();
            return Ok(tasks);
        }

        [HttpPost]
        [Route("InsertTask")]
        public async Task<IActionResult> PostTask(ProjectTaskDTO task)
        {
            await _taskService.InsertProjectTask(task); 
            return Ok("Task has been added.");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteTask(int TaskId)
        {
            await _taskService.DeleteProjectTask(TaskId);
            return Ok();
        }
    }
}
