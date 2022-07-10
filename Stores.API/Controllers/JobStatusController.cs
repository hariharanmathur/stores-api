using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stores.Contract.Inferfaces;
using Stores.Models;

namespace Stores.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class JobStatusController : ControllerBase
    {
        private readonly IJobStatus _jobstatus;
        private IJobStatus? jobstatus;

        public JobStatusController(IJobStatus Jobstatus)
        {
            _jobstatus = jobstatus;
        }
        [HttpGet]
        [Route("get-jobstatus")]
        public async Task<IActionResult> GetJobStatus()
        {
            List<JobStatus> jobstatus = await _jobstatus.GetJobStatus();
            if (jobstatus?.Any() == true)
                return Ok(jobstatus);
            else
                return NoContent();
        }
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetJobStatusById(int id)
        {
            List<JobStatus> jobstatus = await _jobstatus.GetJobStatusById(id);
            if (jobstatus?.Any() == true)
                return Ok(jobstatus);
            else
                return NoContent();
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddJobStatus(JobStatus jobstatus)
        {
            var result = await _jobstatus.AddJobStatus(jobstatus);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateJobStatus(JobStatus jobstatus)
        {
            var result = await _jobstatus.UpdateJobStatus(jobstatus);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteJobStatus(int id)
        {
            var result = await _jobstatus.DeleteJobStatus(id);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }

    }
    }

