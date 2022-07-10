using Stores.Contract.Inferfaces;
using Stores.DAL;
using Stores.Helpers;
using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Contract.Repository
{
    public class JobStatusRepository : IJobStatus
    {
        private readonly IDapperGenericRepository _dapperGenericRepository;
        public JobStatusRepository(IDapperGenericRepository dapperGenericRepository)
        {
            _dapperGenericRepository = dapperGenericRepository;
        }
        public async Task<List<JobStatus>> GetJobStatus()
        {
            return await _dapperGenericRepository.Query<JobStatus>(SqlConstants.JobStatusListQuery);
        }
        public async Task<List<JobStatus>> GetJobStatusById(int id)
        {
            return await _dapperGenericRepository.Query<JobStatus>(SqlConstants.JobStatusListQueryById, new { @id = id });
        }
        public async Task<int> AddJobStatus(JobStatus jobstatus)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.AddJobStatusQuery, new { jobstatusName = jobstatus.StatusName, createdBy = 3 });
        }
        public async Task<int> UpdateJobStatus(JobStatus jobstatus)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.UpdateJobStatusQuery, new { statusName = jobstatus.StatusName, modifiedBy = 3, statusId = jobstatus.StatusId });
        }
        public async Task<int> DeleteJobStatus(int id)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.DeleteJobStatusQuery, new { @id = id });
        }

    }                                                                                        
}
