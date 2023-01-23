using Date.Models;
using Date.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Date.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UserService _userService;
        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var result = _userService.GetAllUsers();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            var result = _userService.GetUserById(id);
            return Ok(result);
        }

        [HttpPost]
        public void AddUser(User user)
        {
            _userService.AddUser(user);
        }

        [HttpPost]
        public void DeleteUser(User user)
        {
            _userService.DeleteUser(user);
        }

        [HttpPut]
        public void UpdateUser(User user)
        {
            _userService.UpdateUser(user);
        }
    }
}
