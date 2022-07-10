using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stores.Contract.Inferfaces;
using Stores.Models;

namespace Stores.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceListController : ControllerBase
    {
        private readonly IServiceList _servicelist;
        public ServiceListController(IServiceList servicelist)
        {
            _servicelist = servicelist;
        }
        [HttpGet]
        [Route("get-servicelist")]
        public async Task<IActionResult> GetServiceLists()
        {
            List<ServiceList> servicelists = await _servicelist.GetServiceLists();
            if (servicelists?.Any() == true)
                return Ok(servicelists);
            else
                return NoContent();
        }
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetServiceListById(int id)
        {
            List<ServiceList> serviclist = await _servicelist.GetServiceListById(id);
            if (serviclist?.Any() == true)
                return Ok(serviclist);
            else
                return NoContent();
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddServiceList(ServiceList servicelist)
        {
            var result = await _servicelist.AddServiceList(servicelist);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateServiceList(ServiceList servicelist)
        {
            var result = await _servicelist.UpdateServiceList(servicelist);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteServiceList(int id)
        {
            var result = await _servicelist.DeleteServiceList(id);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
    }
}
