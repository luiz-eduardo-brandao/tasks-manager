using Microsoft.AspNetCore.Mvc;
using TasksManager.API.DTOs.Requests;
using TasksManager.API.DTOs.Responses;
using TasksManager.API.Services.Interfaces;

namespace TasksManager.API.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Post([FromBody] LoginRequest request) 
        {   
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _userService.LogIn(request);

            if (result.Success)
                return Ok(result);

            return Unauthorized(result);
        }
    }
}