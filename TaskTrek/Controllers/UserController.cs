using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskTrek.Services;

namespace TaskTrek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertUser(string userName)
        {
            await _userService.InsertUser(userName);  

            return Ok($"{userName} has been created as a user.");
        }


        [HttpGet]
        public async Task<IActionResult> GetAllUsers() 
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }
    }
}
