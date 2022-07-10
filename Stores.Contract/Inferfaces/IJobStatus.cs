using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Contract.Inferfaces
{
    public interface IJobStatus
    {
        Task<List<JobStatus>> GetJobStatus();
        Task<List<JobStatus>> GetJobStatusById(int id);
        Task<int> AddJobStatus(JobStatus jobstatus);
        Task<int> UpdateJobStatus(JobStatus jobstatus);
        Task<int> DeleteJobStatus(int id);


    }
}
