using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Contract.Inferfaces
{
    public interface IRoles
    {
        Task<List<Roles>> GetRoles();
        Task<List<Roles>> GetRolesById(int id);
        Task<int> AddRoles(Roles roles);
        Task<int> UpdateRoles(Roles roles);
        Task<int> DeleteRoles(int id);

    }
}
