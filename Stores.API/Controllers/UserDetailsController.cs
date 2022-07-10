using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stores.Contract.Inferfaces;
using Stores.Models;

namespace Stores.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetails _userdetails;
        public UserDetailsController(IUserDetails userdetails)
        {
            _userdetails = userdetails;
        }
        [HttpGet]
        [Route("get-userdetails")]
        public async Task<IActionResult> GetUserDetails()
        {
            List<UserDetails> userdetails = await _userdetails.GetUserDetails();
            if (userdetails?.Any() == true)
                return Ok(userdetails);
            else
                return NoContent();
        }
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetUserDetailsById(int id)
        {
            List<UserDetails> userdetails = await _userdetails.GetUserDetailsById(id);
            if (userdetails?.Any() == true)
                return Ok(userdetails);
            else
                return NoContent();
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddUserDetails(UserDetails userDetails)
        {
            var result = await _userdetails.AddUserDetails(userDetails);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateUserDetails(UserDetails userdetails)
        {
            var result = await _userdetails.UpdateUserDetails(userdetails);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteUserDetails(int id)
        {
            var result = await _userdetails.DeleteUserDetails(id);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
    }
}

