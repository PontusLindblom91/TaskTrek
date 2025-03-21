using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskTrek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult InsertUser(string userName)
        {
            return null;
        }
        [HttpGet]
        public IActionResult GetUsers() 
        {
            return null;
        }
    }
}
