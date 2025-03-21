using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskTrek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTasks()
        {
            return null;
        }

        [HttpPost]
        public IActionResult PostTask(Task task)
        {
            return null;
        }

        [HttpDelete]
        public IActionResult DeleteTask(int TaskId)
        {
            return null;
        }
    }
}
