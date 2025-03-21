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

        // Dependency injection via konstruktor
        public ProjectTaskController(ProjectTaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetTasks()
        {
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> PostTask(ProjectTaskDTO task)
        {
            await _taskService.InsertProjectTask(task); 
            return Ok("Task has been added.");
        }


        [HttpDelete]
        public IActionResult DeleteTask(int TaskId)
        {
            return null;
        }
    }
}
