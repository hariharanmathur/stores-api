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
    public class ServiceListRepository : IServiceList
    {
        private readonly IDapperGenericRepository _dapperGenericRepository;
        public ServiceListRepository(IDapperGenericRepository dapperGenericRepository)
        {
            _dapperGenericRepository = dapperGenericRepository;
        }
        public async Task<List<ServiceList>> GetServiceLists()
        {
            return await _dapperGenericRepository.Query<ServiceList>(SqlConstants.ServiceListListQuery);
        }
        public async Task<List<ServiceList>> GetServiceListById(int id)
        {
            return await _dapperGenericRepository.Query<ServiceList>(SqlConstants.ServiceListListQueryById, new { @id = id });
        }
        public async Task<int> AddServiceList(ServiceList servicelist)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.AddServiceListQuery, new { customerName = servicelist.CustomerName,model = servicelist.Model,jobcardstatus = servicelist.JobCardStatus,description = servicelist.Description,serviceallocateto = servicelist.ServiceAllocatedTo,dateofpurchase = servicelist.DateOfPurchase,jobcardnumber = servicelist.JobCardNumber,phonenumber = servicelist.PhoneNumber });
        }
        public async Task<int> UpdateServiceList(ServiceList servicelist)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.UpdateServiceListQuery, new { customerName = servicelist.CustomerName, modifiedBy = 3, servicelistId = servicelist.ServiceListId });
        }
        public async Task<int> DeleteServiceList(int id)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.DeleteServiceListQuery, new { @id = id });
        }
    }

}
