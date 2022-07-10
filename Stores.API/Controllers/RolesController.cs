using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stores.Contract.Inferfaces;
using Stores.Models;

namespace Stores.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoles _roles;
        private IRoles? roles;

        public RolesController(IRoles roles)
        {
            _roles = roles;
        }
        [HttpGet]
        [Route("get-roles")]
        public async Task<IActionResult> Getroles()
        {
            List<Roles> roles = await _roles.GetRoles();
            if (roles?.Any() == true)
                return Ok(roles);
            else
                return NoContent();
        }
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetRolesById(int id)
        {
            List<Roles> roles = await _roles.GetRolesById(id);
            if (roles?.Any() == true)
                return Ok(roles);
            else
                return NoContent();
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddRoles(Roles roles)
        {
            var result = await _roles.AddRoles(roles);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateRoles(Roles roles)
        {
            var result = await _roles.UpdateRoles(roles);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteRoles(int id)
        {
            var result = await _roles.DeleteRoles(id);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
    }
}
