using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Contract.Inferfaces
{
    public interface IServiceList
    {
        Task<List<ServiceList>> GetServiceLists();
        Task<List<ServiceList>> GetServiceListById(int id);

        Task<int> AddServiceList(ServiceList servicelist);
        Task<int> UpdateServiceList(ServiceList servicelist);
        Task<int> DeleteServiceList(int id);

    }
}
