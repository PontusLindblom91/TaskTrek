using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskTrek.Models;
using TaskTrek.Models.DTOs;
using TaskTrek.Models.Entities;
using TaskTrek.Services;

namespace TaskTrek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SprintsController : ControllerBase
    {
        private readonly SprintService _sprintService;

        public SprintsController(SprintService sprintService)
        {
            _sprintService = sprintService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSprints()
        {
            var sprints = await _sprintService.GetAllSprints();

            return Ok(sprints);
        }

        [HttpPost]
        public async Task<IActionResult> PostSprint(AddSprintDTO sprint)
        {
            await _sprintService.PostSprint(sprint);
            return Ok($"{sprint} has been inserted.");
        }

        [HttpPost("{sprintId}/tasks")]
        public async Task<IActionResult> AddTaskToSprint(int sprintId, int taskId)
        {
            var added = await _sprintService.AddTaskToSprint(sprintId, taskId);
            if (added)
            {
                return Ok($"Task added to Sprint {sprintId}"); 
            }
            else return BadRequest("Could not find a matching task");
        }


    }
}
